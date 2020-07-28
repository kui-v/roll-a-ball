using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;

    void Start() {
        // difference between player GameObject and the camera
        // camera position - player position
        offset = transform.position - player.transform.position;
    }

    // LateUpdate will run every frame, but after all Update() functions in game are done
    // Ensures this does not run before another Update() function
    void LateUpdate() {
        // using solely the position of the player, not directional information
        transform.position = player.transform.position + offset;
    }
}
