using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerColor : MonoBehaviour
{
    [SerializeField] private Image playerUI;
    [SerializeField] private Sprite chessSkin;
    [SerializeField] private Sprite defaultSkin;

    private Color[] playerColors =
    {
        Color.red,
        Color.blue,
        new Color(0.495283f,0.9430465f,1),
        new Color(0, 0.04989147f, 1),
        new Color(0.5221004f, 0, 1)
    };

    public void ChangeColor(int index)
    {
        if (index == 5)
        {
            playerUI.sprite = chessSkin;
            playerUI.color = Color.white;
        }
        else if (index >= 0 && index < playerColors.Length)
        {
            playerUI.sprite = defaultSkin;
            playerUI.color = playerColors[index];
        }
        PlayerPrefs.SetInt("CurrentPlayerSkin", index);
        PlayerPrefs.Save();
    }
}

