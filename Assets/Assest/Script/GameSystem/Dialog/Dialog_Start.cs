using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Dialog_Start : MonoBehaviour
{
    public NPCConversation Conversation;
    void Start()
    {
        ConversationManager.Instance.StartConversation(Conversation);
    }
}
