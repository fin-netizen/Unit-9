using UnityEngine;

public class ObsticleScript : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ManagerScript.scroll == true)
        {
            transform.Translate(Vector2.left * Time.deltaTime);

        }
    }
}
