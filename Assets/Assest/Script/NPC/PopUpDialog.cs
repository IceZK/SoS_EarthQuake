using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public string dialog;
    public TextMeshProUGUI text;
    
    void Update()
    {
        text.text = dialog;
    }
}
