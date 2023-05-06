using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1.0f; //não fica visível no inspetor e tem um valor default de 1 (o ponto zero e o f indica que é um float)
    
    [SerializeField]
    private string playerControls = "Vertical1P";

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        float verticalMovement = Input.GetAxis(playerControls);
        transform.Translate(new Vector2(0, verticalMovement) * moveSpeed * Time.deltaTime);
    }
}
