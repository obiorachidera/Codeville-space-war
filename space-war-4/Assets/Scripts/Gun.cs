using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{    
    public GameObject bulletPrefab; // The bullet prefab to instantiate
    public Transform  firePoint;     //The point from where the bullet is fired

    // Start is called before the first frame update
    void Update()
    {
        //Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Shoot();
        }
    }

    // Update is called once per frame
    void Shoot()
    {
        //Instantiate the bullet at the fire point's position and rotation
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
