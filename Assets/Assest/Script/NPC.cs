using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public NPCConversation Conversation;
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
        ConversationManager.Instance.StartConversation(Conversation);
        }
    }
}
