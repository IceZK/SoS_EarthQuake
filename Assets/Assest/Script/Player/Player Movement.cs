using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float walk_speed;
    public float run_speed;
    public Animator animator;
    public bool isrunning;

    public AudioSource AudioSource;
    public AudioClip AudioClip;
    
    public InputActionReference PlayerAction;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
    }
    public void onPress()
    {
        isrunning = true;
    }

    public void onRelease()
    {
        isrunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.clip = AudioClip;
        Vector2 MoveDirection = PlayerAction.action.ReadValue<Vector2>();
        transform.Translate(MoveDirection*speed*Time.deltaTime);
        if (MoveDirection != Vector2.zero)
        {
            animator.SetFloat("MoveX", MoveDirection.x);
            animator.SetFloat("MoveY", MoveDirection.y);
            if(!AudioSource.isPlaying)
            {
                AudioSource.Play();
                
            }
            

        }
        else if (MoveDirection == Vector2.zero)
        {
            animator.SetFloat("MoveX", 0f);
            animator.SetFloat("MoveY", 0f);
            AudioSource.Stop();
            
        }
        
        if(isrunning)
        {
            speed =  run_speed;
        }
        else
        {
            speed = walk_speed;
        }


    }
}
