using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnScript : MonoBehaviour
{

    public int playerCount;
    public float deathTimer = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FindPlayer();
    }
    void FindPlayer()
    {
        GameObject[] player;
        player = GameObject.FindGameObjectsWithTag("Player");
        playerCount = player.Length;
        if(playerCount == 0)
        {
            deathTimer -= Time.deltaTime;
            if(deathTimer <= 0)
            {
                SceneManager.LoadScene("Level");
                return;
            }
            deathTimer = 2;
            
        }
    }
}
