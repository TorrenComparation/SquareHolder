using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsGenerator : MonoBehaviour
{
    [SerializeField] private GameObject starPrefab;
    Vector2 minPositions = new Vector2(-8, -3);
    Vector2 maxPositions = new Vector2(8, 3);
    private int countOfPrefabs = 20;
    public int currentStarsCount;
    private float minDistance = 2f;

    private void Start()
    {
        currentStarsCount = countOfPrefabs;
        GenerateStars();
    }

    public void GenerateStars()
    {
        List<Vector2> generatedPositions = new List<Vector2>();

        for (int i = 0; i < countOfPrefabs; i++)
        {
            Vector2 spawnPosition;

            do
            {
                spawnPosition = new Vector2(Random.Range(minPositions.x, maxPositions.x), Random.Range(minPositions.y, maxPositions.y));
            } while (IsTooClose(spawnPosition, generatedPositions));

            generatedPositions.Add(spawnPosition);
            Instantiate(starPrefab, spawnPosition, Quaternion.identity);
        }
    }

   private bool IsTooClose(Vector2 position, List<Vector2> existingPositions)
    {
        foreach (Vector2 existingPosition in existingPositions)
        {
            float distance = Vector2.Distance(position, existingPosition);
            if (distance < minDistance)
            {
                return true;
            }
        }

        return false;
    }
}

