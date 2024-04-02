using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public SpriteRenderer sr;
    public InputActionReference PlayerAction;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MoveDirection = PlayerAction.action.ReadValue<Vector2>();
        transform.Translate(MoveDirection*speed*Time.deltaTime);

       

        if(MoveDirection.x < 0)
        {
            sr.flipX = true;
        }
        else if(MoveDirection.x > 0)
        {
            sr.flipX = false;
        }
        
    }
}
