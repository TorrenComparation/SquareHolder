using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ShowCurrent : MonoBehaviour
{
    [SerializeField] private Text currentStarPowderText;
    public int starPowderCount = 0;

    private void Start()
    {
        if(PlayerPrefs.HasKey("StarPowder") == false)
        {
            PlayerPrefs.SetInt("StarPowder", starPowderCount);
            PlayerPrefs.Save();
        }
        else
        {
            starPowderCount = PlayerPrefs.GetInt("StarPowder");
        }
    }

    private void Update()
    {
        currentStarPowderText.text = starPowderCount.ToString();
    }

}
