using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public NPCConversation Conversation;
    void Start()
    {
        ConversationManager.Instance.StartConversation(Conversation);
    }
}
