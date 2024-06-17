using DialogueEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    // Start is called before the first frame update


    public Button b_interact;
    public NPCConversation Conversation;
    public bool CanTalk = false;

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
            else if (collision.gameObject.tag == "MoveObject")
            {
                b_interact.onClick.AddListener(MoveObject);
                Debug.Log("Move");

            }
            else
            {
                
                Debug.Log("Null");
            }
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
    public void MoveObject()
    {

    }

   
}
