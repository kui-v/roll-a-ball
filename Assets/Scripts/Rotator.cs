using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    
    // Before rendering each frame...
    void Update() {
        // Rotate the game object that this script is attached to by 15 in X axis,
        // 30 in Y axis, and 45 in Z axis
        // Multiply by timeDelta to rotate per second, rather than per frame.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); // deltaTime: difference in seconds when the last frame occured
    }
}
