using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscrolling : MonoBehaviour
{
    public float backgroundspeed = 0.1f;// Speed at which the background moves
    public Renderer backgroundRenderer;

    //Update is called once per frame
      void Update()  
    {
           //Calculate the offset for the texture
            float offset = Time.time * backgroundspeed;

           // Apply the offset to the texture
           backgroundRenderer.material.mainTextureOffset = new Vector2(offset, 0);
        
    }
}