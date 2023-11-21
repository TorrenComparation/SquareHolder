using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{

    private int currentStarSkinIndex;
    [SerializeField] private GameObject[] stars;
    public GameObject star;

    private int currentSpikeSkinIndex;
    [SerializeField] private GameObject[] spikes;
    public GameObject spike;

    private int currentPlayerSkinIndex;
    [SerializeField] private GameObject[] playerSkins;
    public GameObject player;
    void Start()
    {


        currentStarSkinIndex = PlayerPrefs.GetInt("CurrentStar");
        currentSpikeSkinIndex = PlayerPrefs.GetInt("CurrentSpike");
        currentPlayerSkinIndex = PlayerPrefs.GetInt("CurrentPlayerSkin");



        star = stars[currentStarSkinIndex];

        spike = spikes[currentSpikeSkinIndex];

        player = playerSkins[currentPlayerSkinIndex];

    }

}
