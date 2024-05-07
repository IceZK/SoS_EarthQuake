using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public Animator animator;
    
    public InputActionReference PlayerAction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MoveDirection = PlayerAction.action.ReadValue<Vector2>();
        transform.Translate(MoveDirection*speed*Time.deltaTime);
        if (MoveDirection != Vector2.zero)
        {
            animator.SetFloat("MoveX", MoveDirection.x);
            animator.SetFloat("MoveY", MoveDirection.y);
        }
        else
        {
            animator.SetFloat("MoveX", 0f);
            animator.SetFloat("MoveY", 0f);
        }
        



    }
}
