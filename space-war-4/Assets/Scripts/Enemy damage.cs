using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydamage : MonoBehaviour
{   
    public int health = 1;//Enemy's health,set to 3 for example
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        //check if the object that collided with the enemy is the player bullet
        if (other.CompareTag("PlayerBullet"))
        {
            TakeDamage(1); //Reduce health by 1 for each bullet hit

            //Destroy the bullet after it hits the enemy
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    private void OnCollisiononEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Die(); // Player dies instantly on contact with the enemy
        }
    }

    void Die()
    {  
        Explode();
        //you can add death effects ,score increases,etc,here
        Destroy(gameObject); // destroy the enemy game object
    }


    void  Explode()
    {
        //Instantiate the explosion effect at the enemy's position and rotation
        GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1f);
    }
}
