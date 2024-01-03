using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crying : MonoBehaviour
{
    public int spawnCounterLimit = 1;
    private int spawnCounter;

    public GameObject[] prefabs;

    void SpawnRandomPrefab()
    {
        // Ensure there are prefabs in the array
        if (prefabs.Length == 0)
        {
            Debug.LogError("Please assign prefabs to the array in the Inspector, nyaa~! (>ω<)");
            return;
        }

        // Randomly choose a prefab from the array
        //GameObject randomPrefab = prefabs[Random.Range(0, prefabs.Length)];
        //GameObject instantiatedPrefab = Instantiate(randomPrefab);
        // Vector2 originalPosition = instantiatedPrefab.transform.position;
        // instantiatedPrefab.transform.position = new Vector2(originalPosition.x + 30f, -3f);
        
        Vector3 spawnPosition = new Vector3(this.gameObject.transform.position.x + 15f, -3f, this.gameObject.transform.position.z);
        SpawnPrefab(spawnPosition);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SpawnRandomPrefab();
        }
    }

    void SpawnPrefab(Vector3 spawnPosition)
    {
        if (spawnCounter >= spawnCounterLimit)
        {
            spawnCounter = 0;
            Debug.Log("Spawn limit reached, nya~ >w<");
        }
        else
        {
            int randomIndex = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomIndex], spawnPosition, Quaternion.identity);
            Vector3 Move = new Vector3(spawnPosition.x + 5f, -3f, spawnPosition.z);
            this.gameObject.transform.position = new Vector3(Move.x +10f, Move.y, Move.z);
            spawnCounter++;
        }
        
    }
}
