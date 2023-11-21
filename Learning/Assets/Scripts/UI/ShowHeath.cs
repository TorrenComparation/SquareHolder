using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHeath : MonoBehaviour
{
   [SerializeField] private Text text;
    private PlayerStatistic statistic;

    private void Start()
    {
        statistic = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatistic>();
    }
    private void Update()
    {
        text.text = statistic.heath.ToString(); 
    }
}
