using UnityEngine;
using UnityEngine.InputSystem;

public class Playerscript : MonoBehaviour
{
    float attackTime;
    int playerLives;
    public Vector2 direction;
    InputAction moveAction;
    InputAction attackAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        attackAction = InputSystem.actions.FindAction("Fire");
        playerLives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Movement(float Speed)
    {
        float horizontal = moveAction.ReadValue<Vector2>().x;
        float vertical = moveAction.ReadValue<Vector2>().y;
    }
}
