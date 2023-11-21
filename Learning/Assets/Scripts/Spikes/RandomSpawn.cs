using System.Collections;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Jobs;

public class RandomSpawn : MonoBehaviour
{
    private GameObject spike;
    public GameObject[] spikeSkins;
    public Transform[] spawns;
    [SerializeField] private int randomazePositions = 0;
    private int lastRandomNumber = 0;
    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn = 1f;

    private int dividedNumber = 2;
    private int currentSpikeSkinIndex;

    private void Start()
    {
        currentSpikeSkinIndex = PlayerPrefs.GetInt("CurrentSpike");
        spike = spikeSkins[currentSpikeSkinIndex];
    }
    private void Update()
    {
     if(timeBetweenSpawn <= 0)
        {
            StartCoroutine(Spawner());
            timeBetweenSpawn = startTimeBetweenSpawn;
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
        
    }

    private IEnumerator Spawner()
    {
        randomazePositions = Random.Range(0, spawns.Length);

        if (lastRandomNumber == randomazePositions)
        {
            if(randomazePositions == 0)
                randomazePositions++;
            else if(randomazePositions % dividedNumber == 0)
                randomazePositions /= dividedNumber; 
            else if(randomazePositions % dividedNumber == 1)
                    randomazePositions--;
        }

        Instantiate(spike, spawns[randomazePositions].position, Quaternion.identity);
        lastRandomNumber = randomazePositions;
        yield return null;
    }
}
