using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            /*if(this.gameObject.name == "RightStairs")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                GameManager.is_down = true;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                GameManager.is_up = true;
            }
            */
            SceneManager.LoadScene(sceneName);



        }
    }
}
