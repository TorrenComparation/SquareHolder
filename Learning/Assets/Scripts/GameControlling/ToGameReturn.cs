using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToGame : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject endPanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && panel.activeInHierarchy == false && startPanel.activeInHierarchy == false && endPanel.activeInHierarchy == false)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && panel.activeInHierarchy == true)
        {
            panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void ToReturn()
    {
        Time.timeScale = 1.0f;
        panel.SetActive(false);
    }
}

