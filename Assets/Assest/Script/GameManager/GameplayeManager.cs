using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameplayeManager : MonoBehaviour
{
    private Scene scene;
    public TextMeshProUGUI text_time;
    public TextMeshProUGUI text_level;
    
    public GameObject player;
    public GameObject ui_control;
    public UnityEvent player_event;
    public UnityEvent player_event2;
    

    // Use this for initialization
    private void Awake()
    {
        player = GameObject.Find("Player");
        
        ui_control = GameObject.Find("Control-Panel");
        


    }
    void Start()
    {
        
        
        
        scene = SceneManager.GetActiveScene();
        Debug.Log("Scene Name" +  scene.name);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        TimerCount(GameManager.timer);
        LevelCount(scene.name);
        GameOver1(GameManager.timer);


        if (scene.name == "Level 1")
        {
            if(GameManager.timer <= 60)
            {
                //spawn object to block player
                //Instantiate(objectToSpawn, position);
            }
        }

        if(GameManager.is_dialog == true)
        {
            ui_control.SetActive(false);
        }
        else if (GameManager.is_dialog == false)
        {
            ui_control.SetActive(true);
        }
        
        

     }
    void GameOver1(float currenttime)
    {
        if (currenttime <= 0.0f)
        {
            SceneManager.LoadScene("Lose", LoadSceneMode.Single);
        }
    }
    void TimerCount(float currenttime)
    {
        if (GameManager.is_dialog == false)
            GameManager.timer -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(currenttime / 60);
        float seconds = Mathf.FloorToInt(currenttime % 60);

        text_time.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    void LevelCount(string scene)
    {
        text_level.text = scene;
    }    
}
