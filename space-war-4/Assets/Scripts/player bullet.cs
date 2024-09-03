using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playerbullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0);
    public float speed = 15;
    [SerializeField]  private float TimebeforeDestroy = 2;
    
     public Vector2 velocity;

     public bool isEnemy = false;
    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, TimebeforeDestroy);
    }

    // Update is called once per frame
    private void Update()
    {
        velocity = direction * speed;
    }



    private void FixedUpdate()
    {
      Vector2 pos = transform.position;

      pos += velocity * Time.fixedDeltaTime;

      transform.position = pos;
    }
}
