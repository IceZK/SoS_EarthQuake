using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.Events;

public class Dialog_Start : MonoBehaviour
{
    public NPCConversation Conversation;
    public DialogEndToDo dialogEndToDo;
    private void Awake()
    {
        dialogEndToDo = GetComponent<DialogEndToDo>();
    }
    void Start()
    {
        ConversationManager.Instance.StartConversation(Conversation);
        dialogEndToDo.enabled = true;

    }
}
