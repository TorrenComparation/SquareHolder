using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private PlayerStatistic statistic;
    private Win result;
    private StarsGenerator generator;
    private Bag starsCount;
    public GameObject endGamePanel;

    private void Start()
    {
        generator = GetComponent<StarsGenerator>();
        starsCount = GameObject.FindGameObjectWithTag("Bag").GetComponent<Bag>();
        statistic = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatistic>();
        result = endGamePanel.GetComponent<Win>();
    }

    private void Update()
    {
        if(starsCount.points == generator.currentStarsCount)
        {
            Time.timeScale = 0f;
            endGamePanel.SetActive(true);
            result.Wins();
        }
        else if(statistic.heath <= 0)
        {
            Time.timeScale = 0f;
            endGamePanel.SetActive(true);
            result.Loose();
        }
    }
}
