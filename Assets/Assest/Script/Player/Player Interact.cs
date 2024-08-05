using DialogueEditor;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInteract : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Canvas Dialog")]
    public Button b_interact;
    public NPCConversation Conversation;

    [Header("varible")]
    public bool CanTalk = false;
    public bool Key = false;
    public float time_damage = 1.0f;
    private float lastDamageTime = 0.0f;

    [Header("Cam Shake")]
    public GameObject Cam;

    [Header("Sound SFX")]
    public AudioSource damage_Sfx;
    public AudioClip damage_clip;
    
    public void Start()
    {
        damage_Sfx = GetComponent<AudioSource>();
        
    }

    public void Update()
    {
        if (CanTalk == true)
            
        {
            if (Conversation != null)
            {
                b_interact.onClick.AddListener(talk);
            }
            

        }
        else if (CanTalk == false)
            b_interact.onClick.RemoveListener(talk);
    }
    // Update is called once per frame 
    public void OnCollisionStay2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "NPC")
            {
                CanTalk = true;
                Conversation = (NPCConversation)collision.gameObject.GetComponent<NPCConversation>();
                
            }
            
            else if (collision.gameObject.tag == "Damage")
            {

                if(Time.time - lastDamageTime>= 1.0f / time_damage)
                {
                    GameManager.timer -= 10f;
                    damage_Sfx.clip = damage_clip;
                    damage_Sfx.Play();
                    lastDamageTime = Time.time;
                }
            }

            if(collision.gameObject.tag == "Key")
            {
                Key = true;
            }

            if (collision.gameObject.tag == "Door")
            {
                if(Key)
                {
                    Key = false;
                    //Event
                }
            }
          
            
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Vibrate")
        {
            Handheld.Vibrate();
            CameraShake.instance.ShakeCam(5f, 1f);
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            Conversation = null;
            CanTalk = false;
        }
            

    }


    public void talk()
    {
        ConversationManager.Instance.StartConversation(Conversation);
    }
    


}
