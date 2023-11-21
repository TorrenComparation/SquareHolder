using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private GameObject player;
    public GameObject[] playerSkins;
    private int currentPlayerSkinIndex;

    private void Awake()
    {
        currentPlayerSkinIndex = PlayerPrefs.GetInt("CurrentPlayerSkin");
        player = playerSkins[currentPlayerSkinIndex];
        Instantiate(player, player.transform.position, Quaternion.identity);
    }
}
