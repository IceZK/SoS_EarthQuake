
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("BGM")]
    [SerializeField]public AudioSource BGM_Music;
    [SerializeField] public AudioSource SFX_Text_source;
    [SerializeField] public AudioSource SFX_Music;
    


    [Header("Audio Clip")]
    [SerializeField] public AudioClip BGM_Title;
    [SerializeField] public AudioClip BGM_Gameplay;

    [Header("SFX Clip")]
    [SerializeField] public AudioClip SFX_Text;
    [SerializeField] public AudioClip SFX_btn;

    public static AudioManager Audio_instacne;
    public bool SFX_is_playing;
    
    
    private void Awake()
    {
        if(Audio_instacne == null)
        {
            Audio_instacne = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
        
    void Start()
    {
        BGM_Music.clip = BGM_Title;
        BGM_Music.Play();
    }
    private void Update()
    {
        //SFX texting
        if(SFX_is_playing == false)
        {
            if (GameManager.is_text == true)
            {
                SFX_is_playing = true;
                SFX_Text_source.clip = SFX_Text;
                SFX_Text_source.loop = true;
                SFX_Text_source.Play();

            }
            else if (GameManager.is_text == false)
            {
                SFX_is_playing = false;
                SFX_Text_source.Stop();
                
            }
        }
        else if (SFX_is_playing != false)
        {
            if (GameManager.is_text == false)
            {
                SFX_is_playing = false;
                SFX_Text_source.Stop();

            }
        }
        //Fix bug BGM title
       if(GameManager.scene.name == "Mainmenu")
        {
            if(BGM_Music.clip != BGM_Title)
            {
                BGM_Music.clip = BGM_Title;
                BGM_Music.Play();
            }
        }
    }

    public void ChangeMusic(AudioClip clip)
    {
        BGM_Music.clip = clip;
        BGM_Music.Play();
    }
    public void ChangeSfx(AudioClip clip)
    {
        SFX_Music.loop = false;
        SFX_Music.clip = clip;
        SFX_Music.Play();
    }
    

    
}
