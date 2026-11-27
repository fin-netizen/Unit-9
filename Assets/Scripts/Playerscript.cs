using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Playerscript : MonoBehaviour
{
    public LayerMask Terrain;
    public RespawnScript respawn;
    public Animator anim;
    float attackTime;
    
    public Vector2 direction;
    InputAction moveAction;
    Rigidbody2D rb;
    InputAction attackAction;
    public WeaponScript Weapon1;
    public WeaponScript Weapon2;
    public Transform LaunchOffset;
    float h, v;
    [SerializeField] private InputActionReference moveActionToUse;
    [SerializeField] private float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        attackAction = InputSystem.actions.FindAction("Fire");

    }

    // Update is called once per frame
    void Update()
    {
        

        Attack();
        Movement();
        LimitPosition();
        
    }

    public void Movement()
    {
        if( ManagerScript.scroll == false )
        {
            return;
        }

        v = moveAction.ReadValue<Vector2>().x;
        h = moveAction.ReadValue<Vector2>().y;
        Vector2 moveDirection = moveActionToUse.action.ReadValue<Vector2>();
        Vector2 finalDirection;
        finalDirection.x = -moveDirection.y;
        finalDirection.y = moveDirection.x;
        transform.Translate(finalDirection * speed * Time.deltaTime);

    }
    void Attack()
    {
        GameObject clone;
        /*
        clone = Instantiate()
        */

    }
    
    void LimitPosition()
    {
        Vector2 pos = transform.position;


        //limit position
        Debug.Log("x=" + pos.x + "   y=" + pos.y);

        if (pos.x < -9.1f)
        {
            pos.x = -9.1f;
        }

        if (pos.x > -0.7f)
        {
            pos.x = -0.7f;
        }
        if (pos.y < -3.9f)
        {
            pos.y = -3.9f;
        }
        if (pos.y > 4.3f)
        {
            pos.y = 4.3f;
        }


        transform.position = pos;


    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Terrain")
        {
            anim.SetBool("dead", true);
            ManagerScript.playerLives--;
            RespawnScript.playerCount--;
            ManagerScript.scroll = false;
            DeathAnimFinished();
            
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public void DeathAnimFinished()
    {
        print("explosion done!");

        Invoke("ReloadScene", 2); // run this method after a period of time
    }

    void ReloadScene()
    {
        if (ManagerScript.playerLives == 0)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            //load scene
            SceneManager.LoadScene("Level");
        }
           
        return;

    }
}
