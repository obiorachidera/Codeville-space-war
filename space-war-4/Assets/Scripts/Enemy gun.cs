using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemygun : MonoBehaviour
{    
    public GameObject bulletPrefab; //the bullet prefab to instantiate
    public Transform firepoint; //the point from where the bullet is fired
    public  float shootingInterval = 2f; // Time between shots

    private float shootingTimer;
    // Start is called before the first frame update
    void Update()
    {
        //Increment the timer
        shootingTimer += Time.deltaTime;

        //shoot when timer reaches the interval
        if(shootingTimer >= shootingInterval)
        {
            Shoot();
            shootingTimer = 0f;
        }
    }

    // Update is called once per frame
    void Shoot()
    {
        //Instantiate the bullet at the fire point's position and rotation
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
