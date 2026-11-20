using UnityEngine;
using UnityEngine.UIElements;

public class ProceduralGeneration : MonoBehaviour
{
    [SerializeField] int width,height;
    [SerializeField] GameObject Roof;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Generation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Generation()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Instantiate(Roof, new Vector2(x, y), Quaternion.identity);
            } 
            
        }
    }
}
