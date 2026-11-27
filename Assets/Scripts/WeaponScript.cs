using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public float Speed = 4.5f;
    float destroyTime = 1.25f;
    private void Update()
    {
        destroyTime -= Time.deltaTime;
        if(destroyTime < 0)
        {
            Destroy(gameObject);
            destroyTime = 1.25f;
        }

        transform.position += -transform.right * Time.deltaTime * Speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
