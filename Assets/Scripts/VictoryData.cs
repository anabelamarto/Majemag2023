using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VictoryData : MonoBehaviour
{

    private TextMeshProUGUI winner;

    // Start is called before the first frame update
    void Start()
    {
        winner = this.GetComponent<TextMeshProUGUI>();
        winner.text = BallMovement.winnerStr + " won!";
        //Debug.Log(winner.text + " won!");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}
