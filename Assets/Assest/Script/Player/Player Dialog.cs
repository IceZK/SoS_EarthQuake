using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialog : MonoBehaviour
{
    public NPCConversation Conversation1;
    
    void Update()
    {
        if(GameManager.is_start == false)
        {
           
            Dialog(Conversation1);
            GameManager.is_start = true;
        }
    }
    void Dialog(NPCConversation Conversation) 
    {
        ConversationManager.Instance.StartConversation(Conversation);
        
    }
}
