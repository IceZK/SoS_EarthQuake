
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("BGM")]
    [SerializeField]public AudioSource BGM_Music;
    [SerializeField] public AudioSource SFX_Music;


    [Header("Audio Clip")]
    [SerializeField] public AudioClip BGM_Title;
    [SerializeField] public AudioClip BGM_Gameplay;

    [Header("SFX Clip")]
    [SerializeField] public AudioClip SFX_Text;


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
        if(SFX_is_playing == false)
        {
            if (GameManager.is_text == true)
            {
                SFX_is_playing = true;
                SFX_Music.clip = SFX_Text;
                SFX_Music.loop = true;
                SFX_Music.Play();

            }
            else if (GameManager.is_text == false)
            {
                SFX_is_playing = false;
                SFX_Music.Stop();
                
            }
        }
        else if (SFX_is_playing != false)
        {
            if (GameManager.is_text == false)
            {
                SFX_is_playing = false;
                SFX_Music.Stop();

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
