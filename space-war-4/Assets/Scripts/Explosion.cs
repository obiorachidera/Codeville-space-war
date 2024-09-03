using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{    
    public float lifetime = 1.0f;// set this the lenght of your explosion animation
    // Start is called before the first frame update
    void ExplosionDone()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
