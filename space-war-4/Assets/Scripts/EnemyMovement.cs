using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float min_Y, max_Y;
    public float min_X, max_X;
    public float moveSpeed = 10f;

    void Update(){
        MoveEnemy();
        CheckIfOffScreen();
    }

    void MoveEnemy(){
        Vector3 temp = transform.position;
        temp.x -= moveSpeed * Time.deltaTime;

        transform.position = temp;
    }


    void CheckIfOffScreen(){
        if (transform.position.x < min_X){
            Destroy(gameObject);
        }
    }
}
