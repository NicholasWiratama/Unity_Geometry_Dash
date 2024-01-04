using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject[] prefabs;
    float spawnRate = 2f; // Adjust this based on your desired spawn frequency
    float nextSpawnTime = 0f;

    [SerializeField] private Transform player;
    
    // Boss Movement
    void Update() {
        MoveBoss();
        SpawnPrefabs();
    }

    void MoveBoss() {
        transform.position = new Vector3(player.position.x + 13f, -3f, this.gameObject.transform.position.z);
        Debug.Log(transform.position);
    }

    // Spawn Prefabs
    void SpawnPrefabs() {
        if (Time.time >= nextSpawnTime) {
            nextSpawnTime = Time.time + 2f / spawnRate; // Update the spawn time

            Vector3 spawnPosition = ChooseSpawnPosition();
            InstantiateRandomPrefab(spawnPosition);
        }
    }

    Vector3 ChooseSpawnPosition() {
        // Choose a random position among the three points (top, middle, bottom)
        float randomY = Random.Range(-6f, 1f); // Adjust the Y values based on your scene
        return new Vector3(transform.position.x, randomY, 0);
    }

    void InstantiateRandomPrefab(Vector3 spawnPosition) {
        // Replace "YourPrefab" with the actual prefab you want to spawn
        int randomIndex = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}