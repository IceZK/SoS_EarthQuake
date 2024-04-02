using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM_Instance;

    //base stat
    [Header("GameSetting")]
    public static float timer = 350;
    public static bool is_gameover;
    public static bool is_escape;
    public static bool is_people;
    public static bool is_alive;
    public static bool is_dialog;

    [Header("Player Position")]
    public static bool is_down;
    public static bool is_up;

    [Header("Player stat")]
    public static int health;
    public static int maxHealth;
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

}
