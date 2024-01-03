using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEndLess : MonoBehaviour
{
    public GameObject Prefab;

    void movePrefab()
    {

        
        Vector3 spawnPosition = new Vector3(this.gameObject.transform.position.x + 400f, -3f, this.gameObject.transform.position.z);
        Instantiate(Prefab, spawnPosition, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            movePrefab();
        }
    }


}
