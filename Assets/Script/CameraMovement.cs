using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Movement.CurrentSpeed>0)
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}

