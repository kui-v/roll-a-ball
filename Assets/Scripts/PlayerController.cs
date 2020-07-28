// Checks every frame for movement
// Apply movement to player object (Update() or FixedUpdate())
// FixedUpdate: applied before any physics update

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  // functions of InputSystem

public class PlayerController : MonoBehaviour {

    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void Start() {
        rb = GetComponent<Rigidbody>(); // sets rb to Rigidbody reference in GameObject
    }

    void OnMove(InputValue movementValue) {
        Vector2 movementVector = movementValue.Get<Vector2>();  // gets Vector2 data from movementValue
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // adds force to player's Rigidbody
    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

}
