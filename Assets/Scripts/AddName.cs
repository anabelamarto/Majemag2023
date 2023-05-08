using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddName : MonoBehaviour
{
    private TextMeshPro playerNameTMP;

    // Start is called before the first frame update
    void Start()
    {
        if(CompareTag("collectNamesP1")){
            playerNameTMP = this.GetComponent<TextMeshPro>();
            playerNameTMP.text = "<rotate=90> " + CollectNames.nameP1.text;
        }
        if(CompareTag("collectNamesP2")){
            playerNameTMP = this.GetComponent<TextMeshPro>();
            playerNameTMP.text = "<rotate=90> " + CollectNames.nameP2.text;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
