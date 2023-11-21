using UnityEngine;
using UnityEngine.Rendering;

public class ChangeDificult : MonoBehaviour
{
    public GameObject spawner;
    private RandomSpawn spawnSpeed;
    private EarnPrize prize;
   
    private void Start()
    {
       
        spawnSpeed = spawner.GetComponent<RandomSpawn>();
        prize = gameObject.GetComponent<EarnPrize>();
    }
    public void Easy()
    {
        prize.prizeForDifficult = 0.8f;
        spawnSpeed.startTimeBetweenSpawn = 0.5f;
    }
    public void Normal()
    {
        prize.prizeForDifficult = 1.2f;
        spawnSpeed.startTimeBetweenSpawn = 0.25f;
    }
    public void Hard()
    {

        prize.prizeForDifficult = 1.7f;
        spawnSpeed.startTimeBetweenSpawn = 0.1f; 
    }
}
