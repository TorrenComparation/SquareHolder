using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

public class ChangeSpikeColor : MonoBehaviour
{
    [SerializeField] private Image[] spikeUI;


    private Color[] spikeColors =
    {
         new Color(0.8862745f,0.8862745f,0.8862745f),
         new Color(0.5019608f,0.2745098f,0),
         new Color(0.3960784f,0,0),
         new Color(1,0.8705882f,0),
         new Color(0,0.9803922f,1),
         new Color(0.7137255f,1,0)
    };

    public void ChangeColor(int index)
    {
       
      if (index >= 0 && index < spikeColors.Length)
        {
            for (int i = 0; i < spikeUI.Length; i++)
            {
                spikeUI[i].color = spikeColors[index];
            }
        }
        PlayerPrefs.SetInt("CurrentSpike", index);
        PlayerPrefs.Save();
    }
}
