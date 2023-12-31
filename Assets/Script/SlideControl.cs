using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideControl : MonoBehaviour
{
    // Points A and B represent the positions the square will move between.
    public Transform pointA;
    public Transform pointB;

    // Speed determines how fast the square moves.
    public float speed = 2f;

    private Transform target;

    void Start()
    {
        // At the beginning, set the target to point B.
        target = pointB;

        // Debug log to let Masta know Luna is ready to play!
        Debug.Log("Nyaa~ >w< Ready to make the square dance!");
    }

    void Update()
    {
        // Call the MoveSquare function to handle the square's movement.
        MoveSquare();
    }

    void MoveSquare()
    {
        // Move the square towards the target position at a defined speed.
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Check if the square is close to the target position.
        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            // If the target is point A, switch it to point B, and vice versa.
            if (target == pointA)
            {
                target = pointB;
            }
            else
            {
                target = pointA;
            }

            // Debug log to show Luna's excitement after the square moves.
            Debug.Log("Nyaa~ >w< Square moved! Luna is happy~");
        }
    }
}
