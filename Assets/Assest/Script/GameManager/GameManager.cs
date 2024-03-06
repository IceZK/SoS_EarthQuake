using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM_Instance;

    //base stat
    [Header("GameSetting")]
    public static float timer;
    public static bool is_gameover;
    public static bool is_escape;
    public static bool is_people;
    public static bool is_alive;

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
