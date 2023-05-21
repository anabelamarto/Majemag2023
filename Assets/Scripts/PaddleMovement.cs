using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1.0f; //não fica visível no inspetor e tem um valor default de 1 (o ponto zero e o f indica que é um float)
    
    [SerializeField]
    private string axisName = "Vertical1P";

    private Rigidbody2D paddleRB;

    [SerializeField]
    private Camera mainCamera;

    private float verticalMovement;

    // Start is called before the first frame update
    private void Start()
    {
        paddleRB = this.GetComponent<Rigidbody2D>();

        Vector3 point = new Vector3();
        point = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width/22f, Screen.height/2f, mainCamera.nearClipPlane));
        if (axisName == "Vertical1P")
            paddleRB.position = point;
        else
            paddleRB.position = point*-1;
        
    }

    // Update is called once per frame
    private void Update(){
        verticalMovement = Input.GetAxis(axisName); 
    }

    // FixedUpdate has the frequency of the physics system; it is called every fixed frame-rate frame
    private void FixedUpdate()
    {
        //Time.deltaTime corresponde ao tempo que demorou a renderizar o último frame. Só faz sentido quando está no Update. Aqui vou precisar de outro: ver como funciona o time-Delta time e ver qual é a alternativa para o fixed update
        Vector2 moveForce = new Vector2(0, verticalMovement) * moveSpeed * Time.deltaTime;
        paddleRB.AddForce(moveForce);
    }

}
