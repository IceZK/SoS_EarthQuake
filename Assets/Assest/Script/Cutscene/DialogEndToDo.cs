using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogEndToDo : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent NextTo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.is_dialog == false) 
        {
            NextTo.Invoke();
            Destroy(this.gameObject);
        }
    }
}
