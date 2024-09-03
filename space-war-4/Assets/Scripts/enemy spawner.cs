using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{    
    public GameObject enemyPrefab; //The enemy prefab to spawn
    public float spawnInterval = 2f; //The Interval between spawns
    public float spawnXOffset = 10f; //How far off-screen to the right enemies spawn
    public float moveSpeed = 5f;//Speed at which enemies move left
    public float minY = 4f; //minimum Y position for spawning
    public float maxY = 4f;// Maximum Y position for spawning

    private float timeSinceLastSpawn = 0f;
    // Start is called before the first frame update
    void Update()
    {  
        //Track time and spawn enemies at regular intervals
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnergy();
            timeSinceLastSpawn = 0f;
        }
        
    }

    // Update is called once per frame
    void SpawnEnergy()
    {  
        //Randomize the y position within a specified range
        float spawnY = Random.Range(minY, maxY);

        //set the x position to the right side, off_screen
        float spawnX = Camera.main.transform.position.x + spawnXOffset;

        //create the spawn position vector 
        Vector2 spawnPosition = new Vector2(spawnX, spawnY);

        //Instantiate the enemy at the spawn position 
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        
        //move the enemy left by applying velocity directly
        Rigidbody2D enemyRb = enemy.GetComponent<Rigidbody2D>();
        if (enemyRb != null)
        {
            enemyRb.velocity = Vector2.left * moveSpeed;
        }        
    }
}
