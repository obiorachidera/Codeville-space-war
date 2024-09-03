using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{    public GameObject GameOverPanel;
      void Update()
      {
          if(GameObject.FindGameObjectWithTag("Player") == null) //set GameOverPanel to be active
          {
            GameOverPanel.SetActive(true);
          }
      }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
        

}
