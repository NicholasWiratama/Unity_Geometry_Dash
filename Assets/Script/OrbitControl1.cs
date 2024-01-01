using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitControl : MonoBehaviour
{
    // The point around which the object will orbit
    public Transform orbitPoint;

    // Rotation speed in degrees per second
    public float rotationSpeed = 45f;

    void Update()
    {
        // Ensure the orbit point is not null
        if (orbitPoint != null)
        {
            // Calculate the rotation axis in 2D
            Vector2 orbitAxis = (Vector2)transform.position - (Vector2)orbitPoint.position;

            // Rotate the object around the point
            transform.RotateAround(orbitPoint.position, Vector3.forward, rotationSpeed * Time.deltaTime);

        }
        else
        {
            Debug.LogError("Please assign an orbit point in the Inspector, nyaa~! (>ω<)");

        }
    }
}
