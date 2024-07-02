using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public static bool is_pause;
    public static bool is_text;


    public static Scene scene;




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

    private void Update()
    {
        scene = SceneManager.GetActiveScene();
    }



}
