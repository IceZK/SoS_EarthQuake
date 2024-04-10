using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTime : MonoBehaviour
{
    public float time_decrase;
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collsion");
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Obstacle");
            GameManager.timer -= time_decrase;
        }
    }
}
