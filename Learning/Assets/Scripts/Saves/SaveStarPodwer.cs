using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStarPodwer : MonoBehaviour
{
    [SerializeField]private int starPowderCount;
    [SerializeField]private int loadedStarPowderCount;

    private void Start()
    {
        starPowderCount = FindAnyObjectByType<EndGame>().GetComponent<EndGame>().starPowder;
        
        if(PlayerPrefs.HasKey("StarPowder") == false)
        {
            PlayerPrefs.SetInt("StarPowder", 0);
        }
        else
        {
            loadedStarPowderCount = PlayerPrefs.GetInt("StarPowder");
            PlayerPrefs.SetInt("StarPowder", loadedStarPowderCount+starPowderCount);
            PlayerPrefs.Save();
        }
    }

   
}
