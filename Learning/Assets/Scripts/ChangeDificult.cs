using UnityEngine;

public class ChangeDificult : MonoBehaviour
{
    public GameObject spawner;
    private RandomSpawn spawnSpeed;
    private void Start()
    {
        spawnSpeed = spawner.GetComponent<RandomSpawn>();
    }
    public void Easy()
    {
        spawnSpeed.startTimeBetweenSpawn = 0.5f;
    }
    public void Normal()
    {
        spawnSpeed.startTimeBetweenSpawn = 0.25f;
    }
    public void Hard()
    {
        spawnSpeed.startTimeBetweenSpawn = 0.1f; 
    }
}
