using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialog : MonoBehaviour
{
    public NPCConversation Conversation1;
    public NPCConversation Conversation2;
    public NPCConversation Conversation3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.is_start == false)
        {
            GameManager.is_start = true;
            Dialog(Conversation1);
        }
    }
    void Dialog(NPCConversation Conversation) 
    {
        ConversationManager.Instance.StartConversation(Conversation);
    }
}
