using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.is_pause = true;
    }

    public void Resume()
    {
        GameManager.is_pause = false;
    }

    
}
