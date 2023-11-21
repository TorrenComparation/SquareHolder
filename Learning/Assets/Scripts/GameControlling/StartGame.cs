using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject StartPanel;

   private void Start()
    {
        Time.timeScale = 0f;
    }
    
    public void StartOurGame()
    {
        Time.timeScale = 1f;
        StartPanel.SetActive(false);
    }
}
