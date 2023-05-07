using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddName : MonoBehaviour
{
    private TextMeshProUGUI playerNameTMP;

    // Start is called before the first frame update
    void Start()
    {
        playerNameTMP = this.GetComponent<TextMeshProUGUI>();
        playerNameTMP.text = CollectNames.nameP1.text;
        Debug.Log(playerNameTMP);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
