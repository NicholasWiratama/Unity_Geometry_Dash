using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryingEndless : MonoBehaviour
{
    public GameObject[] prefabs;

    void SpawnRandomPrefab()
    {
        // Ensure there are prefabs in the array
        if (prefabs.Length == 0)
        {
            Debug.LogError("Please assign prefabs to the array in the Inspector, nyaa~! (>ω<)");
            return;
        }
        
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

            int randomIndex = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[randomIndex], spawnPosition, Quaternion.identity);
            Vector3 Move = new Vector3(spawnPosition.x + 5f, -3f, spawnPosition.z);
            this.gameObject.transform.position = new Vector3(Move.x +10f, Move.y, Move.z);
      
    }
}
