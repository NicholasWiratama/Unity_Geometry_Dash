using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject[] prefabs;
    float spawnRate = 2f; 
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

    void SpawnPrefabs() {
        if (Time.time >= nextSpawnTime) {
            nextSpawnTime = Time.time + 2f / spawnRate;

            Vector3 spawnPosition = ChooseSpawnPosition();
            InstantiateRandomPrefab(spawnPosition);
        }
    }

    Vector3 ChooseSpawnPosition() {
        float randomY = Random.Range(-6f, 1f); 
        return new Vector3(transform.position.x, randomY, 0);
    }

    void InstantiateRandomPrefab(Vector3 spawnPosition) {
        int randomIndex = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}