using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM_Instance;

    //base stat
    [Header("GameSetting")]
    public static float timer = 360;
    public static bool is_start;
    public static bool is_gameover;
    public static bool is_escape;
    public static bool is_people;
    public static bool is_alive;
    public static bool is_dialog;

    

    

    
    
    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (GM_Instance != null && GM_Instance != this)
        {
            Destroy(this.gameObject);

        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            GM_Instance = this;


        }
    }
    
   
    public void Reset()
    {
        is_dialog = false;
        is_gameover = false;
        is_escape = false;
        is_people = false;
        is_start = false;
        timer += (360f + Time.deltaTime);
        
    }

}
