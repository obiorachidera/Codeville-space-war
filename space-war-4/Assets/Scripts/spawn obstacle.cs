using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class spawnobstacle : MonoBehaviour
{
    public GameObject obstacle;
 public float max_X;
 public float min_X;
 public float max_Y;
 public float min_Y;
 public float timeBetweeenSpawn;
 private float spawnTime;


 void Update()
 {
    if(Time.time > spawnTime){
        Spawn();
        spawnTime = Time.time +  timeBetweeenSpawn;

    }
 }

void Spawn(){
    float randomX = Random.Range(min_X,max_X);
    float randomY = Random.Range(min_Y,max_Y);
    Instantiate(obstacle, transform.position + new Vector3(randomX, randomY,0),transform.rotation);
}

}


