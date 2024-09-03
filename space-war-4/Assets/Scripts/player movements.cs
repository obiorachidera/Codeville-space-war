using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovements : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the movement speed is the inspector

    // Update is called once per frame
    void Update()
    {
        // Get Input from the arrow keys or WASD keys
        float moveX = Input.GetAxis("Horizontal"); // Left/Right movement
        float moveY = Input.GetAxis("Vertical"); //  Up/Down movement 

        //Create a Vector3 based on input
        Vector3 movement = new Vector3(moveX, moveY, 0f) * moveSpeed * Time.deltaTime;

        // Move the player
        transform.Translate(movement);
    }
}