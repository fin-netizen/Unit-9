using UnityEngine;
using UnityEngine.InputSystem;

public class Playerscript : MonoBehaviour
{
    float attackTime;
    int playerLives;
    public Vector2 direction;
    InputAction moveAction;
    Rigidbody2D rb;
    InputAction attackAction;
    public WeaponScript Weapon1 ;
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
        playerLives = 3;
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
}
