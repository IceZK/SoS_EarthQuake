using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Dialog_Interact : MonoBehaviour
{
    [SerializeField]
    public NPCConversation Conversation;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ConversationManager.Instance.StartConversation(Conversation);
        }
    }
}
