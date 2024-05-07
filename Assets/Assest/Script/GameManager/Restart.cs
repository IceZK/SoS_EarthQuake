using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public void ReBool()
    {
        GameManager.timer = time;
        GameManager.is_dialog = false;
        
        GameManager.is_gameover = false;
        GameManager.is_escape = false;
        GameManager.is_people = false;
        GameManager.is_start = false;
    }
}
