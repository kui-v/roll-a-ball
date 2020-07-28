// Checks every frame for movement
// Apply movement to player object (Update() or FixedUpdate())
// FixedUpdate: applied before any physics update

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  // functions of InputSystem
using TMPro;

public class PlayerController : MonoBehaviour {

    public float speed = 0;
    public TextMeshProUGUI countText;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    void Start() {
        rb = GetComponent<Rigidbody>(); // sets rb to Rigidbody reference in GameObject
        count = 0;

        SetCountText(); // init
    }

    void OnMove(InputValue movementValue) {
        Vector2 movementVector = movementValue.Get<Vector2>();  // gets Vector2 data from movementValue
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText() {
        countText.text = "Count: " + count.ToString();
    }

    // adds force to player's Rigidbody
    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    // need to detect collisions; calls when Player touches trigger collider (other)
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pickup")) {
            other.gameObject.SetActive(false);  // disables game object of cube with Pickup tag
            count = count + 1;

            SetCountText();
        }
    }
}
