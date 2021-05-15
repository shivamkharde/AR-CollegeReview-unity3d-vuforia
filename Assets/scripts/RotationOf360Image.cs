using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOf360Image : MonoBehaviour
{
    //defining speed variables
public float horizontalSpeed = 2.0f;
public float verticalSpeed  = 2.0f;

//for vertical axis rotation
public float yaw = 0.0f;

//for horizontal axis rotation
public float pitch = 0.0f;

    // Update is called once per frame
    void Update()
    {
yaw += horizontalSpeed * Input.GetAxis("Mouse X");
pitch -= verticalSpeed * Input.GetAxis("Mouse Y");
transform.eulerAngles = new Vector3(pitch,yaw,0.0f);
        
    }
}
