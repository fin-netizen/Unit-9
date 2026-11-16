using UnityEngine;
using UnityEngine.InputSystem;

public class Playerscript : MonoBehaviour
{
    float attackTime;
    int playerLives;
    public Vector2 direction;
    InputAction moveAction;

    InputAction attackAction;

    float h, v;

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
        Movement();
        
    }

    public void Movement()
    {
        h = moveAction.ReadValue<Vector2>().x;
        v = moveAction.ReadValue<Vector2>().y;
    }
}
