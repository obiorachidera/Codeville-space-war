using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BGscrolling : MonoBehaviour
{
    public float backgroundSpeed;

    public Renderer backgroundRenderer;



    private void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }


     
    
    
    
    
}