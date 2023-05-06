using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float speedValue = 4.0f;

    private Rigidbody2D ballRB;

    // Start is called before the first frame update
    private void Start()
    {
        ballRB = this.GetComponent<Rigidbody2D>();    
        ballRB.velocity = new Vector2(speedValue,0);
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("paddle")){
            speedValue *= -1;
            Vector2 invertVelocity = new Vector2(speedValue, 0);
            ballRB.velocity = invertVelocity;
        } 
    }
}
