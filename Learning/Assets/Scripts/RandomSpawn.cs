using System.Collections;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject spike;
    public Transform[] spawns;
    [SerializeField] private int positions;
    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn = 1f;
   

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
       
        positions = Random.Range(0, spawns.Length);
        Instantiate(spike, spawns[positions].position, Quaternion.identity);
        yield return null;
    }
}
