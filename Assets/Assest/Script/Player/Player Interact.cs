using DialogueEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    // Start is called before the first frame update


    public Button b_interact;
    public NPCConversation Conversation;
    
    
    // Update is called once per frame 
    public void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.tag == "NPC")
            {
                Conversation = (NPCConversation)collision.gameObject.GetComponent<NPCConversation>();
                b_interact.onClick.AddListener(talk);
                
            }
            else if (collision.gameObject.tag == "MoveObject")
            {
                b_interact.onClick.AddListener(MoveObject);

            }
            else
            {
                
                Debug.Log("Null");
            }
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
