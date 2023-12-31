using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform otherObject;
    public Vector2 newPosition = new Vector2(0f, 0f);
    public bool moveBackOnExit = true;
    private Vector2 originalPosition;

    void Start()
    {
        originalPosition = otherObject.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            otherObject.position = newPosition;

            // Meow~! Other object has been moved to the new position! Nyaa~ >w<
            Debug.Log("Other object has been moved to the new position! Nyaa~ >w<");
        }
    }

}
