using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStarColor : MonoBehaviour
{
    [SerializeField] private Image[] starsUI;
    [SerializeField] private Sprite multiStar;
    [SerializeField] private Sprite star;

    private Color[] StarColors =
    {
        Color.white,
        Color.green,
        Color.red,
        new Color(1, 0.4901961f, 0, 1),
        new Color(0.627451f, 1, 0)
    };

    public void ChangeColor(int index)
    {
        if (index == 5)
        {
            for (int i = 0; i < starsUI.Length; i++)
            {
                starsUI[i].sprite = multiStar;
                starsUI[i].color = Color.white;
            }
        }
        else if (index >= 0 && index < StarColors.Length)
        {
            for (int i = 0; i < starsUI.Length; i++)
            {
                starsUI[i].sprite = star;
                starsUI[i].color = StarColors[index];
            }
        }
        PlayerPrefs.SetInt("CurrentStar", index);
        PlayerPrefs.Save();
    }
}