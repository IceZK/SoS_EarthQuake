using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSound : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Music;
    AudioManager audio_manager;
    void Start()
    {
        Music = GameObject.Find("AudioManager");
        audio_manager = Music.GetComponent<AudioManager>();
    }

    // Update is called once per frame
    public void ClickSound()
    {
        audio_manager.ChangeSfx(audio_manager.SFX_btn);
    }
}
