using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float speedValueX = 4.0f;

    [SerializeField]
    private float speedValueY = 4.0f;

    private Rigidbody2D ballRB;

    // Start is called before the first frame update
    private void Start()
    {
        ballRB = this.GetComponent<Rigidbody2D>();    
        ballRB.velocity = new Vector2(speedValueX,speedValueY);
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("paddle")){
            speedValueX *= -1;
            Vector2 invertVelocity = new Vector2(speedValueX, speedValueY);
            ballRB.velocity = invertVelocity;
        } 

        if(collision.gameObject.CompareTag("wall")){
            speedValueY *= -1;
            Vector2 invertVelocity = new Vector2(speedValueX, speedValueY);
            ballRB.velocity = invertVelocity;
        } 
    }
}
