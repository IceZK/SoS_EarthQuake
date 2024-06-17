using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Enter_Cutscene : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayableDirector Cutscene;
    public BoxCollider2D boxCollider2D;
    void Start()
    {
        Cutscene = GetComponent<PlayableDirector>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Trigger");
            Cutscene.enabled = true;
            boxCollider2D.enabled = false;
        }
    }
}
