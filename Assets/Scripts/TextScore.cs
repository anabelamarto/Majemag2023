using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScore : MonoBehaviour
{
    // Start is called before the first frame update
    private string inputText;
    void Start()
    {
        inputText = this.GetComponent<TextMeshProUGUI>().text;
        //Debug.Log("This is TextMeshProUGUI:" + inputText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
