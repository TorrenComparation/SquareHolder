using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour
{
    [SerializeField] private string name;
    [SerializeField] private int price;
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject errorPanel;
    [SerializeField] private Text priceText;
    private ShowNotEnoughtMoney notEnoughtMoney;
    private int insufficientNumber;
    private float livingTime = 2f;
    private ShowCurrent starPowder;

    private void Start()
    {
        starPowder = FindAnyObjectByType<ShowCurrent>().GetComponent<ShowCurrent>();
        priceText.text = price.ToString();

        if(PlayerPrefs.HasKey(name))
        {
            Destroy(Panel);
        }
    }

    public void Purchase()
    {
        insufficientNumber = price - starPowder.starPowderCount;
        if (starPowder.starPowderCount - price >= 0)
        {
            starPowder.starPowderCount -= price;
            PlayerPrefs.SetInt("StarPowder", starPowder.starPowderCount);
            PlayerPrefs.Save();
            PlayerPrefs.SetString(name, name.ToLower());
            PlayerPrefs.Save();
            Destroy(Panel);
        }
        else if (starPowder.starPowderCount - price < 0 && errorPanel.activeInHierarchy == false)
        {
            errorPanel.SetActive(true);
            notEnoughtMoney = errorPanel.GetComponent<ShowNotEnoughtMoney>();
            notEnoughtMoney.starPowderCount = insufficientNumber;
        }
    }
}
