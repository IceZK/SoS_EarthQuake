using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void ReBool()
    {
        GameManager.timer = 360f;
        GameManager.is_dialog = false;
        
        GameManager.is_gameover = false;
        GameManager.is_escape = false;
        GameManager.is_people = false;
        GameManager.is_start = false;
        GameManager.is_pause = false;
        GameManager.is_text = false;
    }
}
