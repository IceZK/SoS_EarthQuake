using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixUi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UI;
    void Start()
    {
        UI = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.is_pause)
            UI.SetActive(false);
        else
            UI.SetActive(true);
    }
}
