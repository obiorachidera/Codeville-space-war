using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{   
    public float speed = 5f;
    public float deactivate_timer = 3f ;
    public Vector2 direction;
    public bool isEnemy = true;


    private void OnEnable()
    {
        //start the deactivation timer when the bullet is activated
        Invoke("Deactivation" , deactivate_timer); 
    }
    
    private void OnDisable()
    {
        //cancel the deactivation timer if the bullet is deactivated early
        CancelInvoke();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }


    void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
