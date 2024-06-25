using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Music;
    AudioManager audio_manager;
    public AudioSource audio_source;
    
    public bool win;
    public bool lose;


    public AudioClip sfx_win;
    public AudioClip sfx_lose;
    void Start()
    {
        Music = GameObject.Find("AudioManager");
        audio_source = GetComponent<AudioSource>();

        if (win)
        {
            audio_source.clip = sfx_win;
            audio_source.Play();
            if (audio_manager.BGM_Music.clip != audio_manager.BGM_Title)
            {
                audio_manager.ChangeMusic(audio_manager.BGM_Title);
            }

        }
        else
        {
            audio_source.clip = sfx_lose;
            audio_source.Play();
            if (audio_manager.BGM_Music.clip != audio_manager.BGM_Title)
            {
                audio_manager.ChangeMusic(audio_manager.BGM_Title);

            }

        }
    }
    private void Update()
    {
        
       
    }
    // Update is called once per frame

}
