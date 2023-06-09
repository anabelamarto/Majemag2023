using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float speedValueX = 5.0f;

    [SerializeField]
    private float speedValueY = 5.0f;

    private Rigidbody2D ballRB;
    private Vector2 initialPosition;
    private Vector2 initialVelocity;

    private int player1Score = 0;
    
    [SerializeField]
    private TextMeshProUGUI player1Text;
    
    private int player2Score = 0;
    [SerializeField]
    private TextMeshProUGUI player2Text;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private int winnerScore = 15;

    public static string winnerStr;

    // Start is called before the first frame update
    private void Start()
    {
        ballRB = this.GetComponent<Rigidbody2D>();    
        initialPosition = ballRB.position;

        randomSpeed();
        //initialVelocity = ballRB.velocity;        
    }

    // Update is called once per frame
    private void Update()
    {   

    }

    private void randomSpeed(){
        int randomSpeed = Random.Range(0,2);
        if (randomSpeed == 0)
            speedValueX *=-1;

        randomSpeed = Random.Range(0,2);
        if (randomSpeed == 0)
            speedValueY *=-1;

        ballRB.velocity = new Vector2(speedValueX,speedValueY);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("paddle")){
            speedValueX *= -1;
            Vector2 invertVelocity = new Vector2(speedValueX, speedValueY);
            ballRB.velocity = invertVelocity;
            PlayCollisionSound();
        } 

        if(collision.gameObject.CompareTag("wall")){
            speedValueY *= -1;
            Vector2 invertVelocity = new Vector2(speedValueX, speedValueY);
            ballRB.velocity = invertVelocity;
        } 

        if(collision.gameObject.CompareTag("P1score") || collision.gameObject.CompareTag("P2score")){
            PlayPointSound();
            if(collision.gameObject.CompareTag("P1score")){  
                player1Score += 1;
                player1Text.text = player1Score.ToString();
            }
            else{
                player2Score +=1;
                player2Text.text = player2Score.ToString();
            }
            randomSpeed();
            PlayerScored();
        } 
    }

    private void PlayerScored(){
        if (player1Score == winnerScore){
            
            string winner = CollectNames.nameP1;
            //SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
            Victory(winner);
        }
        else if(player2Score == winnerScore){
            string winner = CollectNames.nameP2;
            Victory(winner);
        }

            ballRB.position = initialPosition;
            ballRB.velocity = initialVelocity;
            randomSpeed();
    }

    private void PlayCollisionSound(){
        AudioClip audioClip = Resources.Load<AudioClip>("Collision");
        audioSource.PlayOneShot(audioClip);
    }

    private void PlayPointSound(){
        audioSource.clip = Resources.Load<AudioClip>("Death");
        audioSource.Play();
    }

/*    private void RestartGame(){
        player1Score = 0;
        player2Score = 0;
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }
*/

    public void Victory(string winner){
        winnerStr = winner;
        SceneManager.LoadScene("VictoryScene", LoadSceneMode.Single);
    }
}
