using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectNames : MonoBehaviour
{
    public static string nameP1;
    private TMP_InputField nameInputField;
    public static string nameP2;

    // Start is called before the first frame update
    void Start()
    {       
        nameInputField = this.GetComponent<TMP_InputField>();
        nameInputField.onEndEdit.AddListener(TextMeshUpated);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log(nameP1.text);*/
    }

    public void TextMeshUpated(string name){
        if(CompareTag("collectNamesP1")){
            nameP1 = this.GetComponent<TMP_InputField>().text;
        }
        else if(CompareTag("collectNamesP2")){
            nameP2 = this.GetComponent<TMP_InputField>().text;        
        }        
    }
}
