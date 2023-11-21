using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHolder : MonoBehaviour
{
    public GameObject musicPrefab;
    private AudioSource audio;
    public GameObject[] objects;

    private void Awake()
    {
        objects = GameObject.FindGameObjectsWithTag("Sound");
        if (objects.Length == 0)
        {
            musicPrefab = Instantiate(musicPrefab);
            musicPrefab.name = "musicPrefab";
            DontDestroyOnLoad(musicPrefab);

        }
        else
        {
            musicPrefab = GameObject.Find("musicPrefab");
        }
    }
    private void Start()
    {
        audio = musicPrefab.GetComponent<AudioSource>();
    }
}
