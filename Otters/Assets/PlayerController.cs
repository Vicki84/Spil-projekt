using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public Vector2 movementDirection;
    public float movementSpeed;
    public Rigidbody2D rb;
    public float addMovementSpeed = 3f;
    public float maxSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        Move();
    }

    void ProcessInput() {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), 0 );
        movementSpeed = Mathf.Clamp(movementDirection.magnitude,0.0f,1.0f);
        movementDirection.Normalize();
    }
    void Move() {
        if(rb.velocity.magnitude < maxSpeed) {
            rb.AddForce(movementDirection*addMovementSpeed);
        }
        
    }
}
