using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{     
    public int maxHealth = 3;
    [SerializeField] private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize player health
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth >= 0)
        {
            Die();
        }
    }


    void Die()
    {
        //Add logic for player death ,e.g,play death animation,show game over screen
        Debug.Log("player Died");
        Destroy(gameObject); //Destroy the player Game object
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if the element is an enemy bullet
        Enemybullet bullet = collision.GetComponent<Enemybullet>();
        if (bullet != null && bullet.isEnemy)
        {
            TakeDamage(1); //Assume each bullet does 1 damage

            Destroy(bullet.gameObject); //Destroy the bullet
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the collided with an enemy 
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Die(); //player dies instantly on the contact with the enemy
            GameOver();
        }
    }


    private void GameOver()
    {
       Time.timeScale = 0;
    }
}
