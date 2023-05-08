using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectNames : MonoBehaviour
{
    public static TMP_InputField nameP1;

    // Start is called before the first frame update
    void Start()
    {       
        nameP1 = this.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log(nameP1.text);*/
    }
}
