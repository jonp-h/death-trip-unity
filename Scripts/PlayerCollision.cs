using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("crash");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
