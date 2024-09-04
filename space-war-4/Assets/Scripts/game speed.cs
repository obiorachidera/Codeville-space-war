using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamespeed : MonoBehaviour
{
   public float initialTimeScale = 1.0f; //starting speed of the gate
   public float maxTimeScale = 5.0f; //Maximum speed the game can reach
   public float speedIncreaseRate = 0.5f; //How quickly the speed increases
   public float timeToMaxSpeed = 60f; // Time in seconds to reach max speed
   public float elaspedTime = 0f;


   void Start()
   {
     //set the initial time scale when the game starts 
     Time.timeScale = initialTimeScale;
   }


   void Update()
   {
     //Increases elasped time by the time passed since the last frame
     elaspedTime += Time.deltaTime;
     // calculate the new time scale based on elasped time 
     float newTimeScale = Mathf.Lerp(initialTimeScale, maxTimeScale, elaspedTime / timeToMaxSpeed);
     //Apply the new time scale 
     Time.timeScale = newTimeScale;
     //optionally clamp the time scale to the max value to avoid exceeding it 
     Time.timeScale = Mathf.Clamp(Time.timeScale, initialTimeScale, maxTimeScale);
   }

   //Reseting the time scale when the game ends or reset 
   void OnDestroy()
   {
     Time.timeScale = 1.0f;
   }
}
