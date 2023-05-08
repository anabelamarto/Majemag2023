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
        playerNameTMP = this.GetComponent<TextMeshPro>();
        playerNameTMP.text = "<rotate=90> " + CollectNames.nameP1.text;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
