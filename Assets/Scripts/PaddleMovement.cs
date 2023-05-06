using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1.0f; //não fica visível no inspetor e tem um valor default de 1 (o ponto zero e o f indica que é um float)
    
    [SerializeField]
    private string axisName = "Vertical1P";

    private Rigidbody2D paddleRB;
    

    // Start is called before the first frame update
    private void Start()
    {
        paddleRB = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float verticalMovement = Input.GetAxis(axisName); 
        Vector2 moveForce = new Vector2(0, verticalMovement) * moveSpeed * Time.deltaTime;
        
        paddleRB.AddForce(moveForce);
    }
}
