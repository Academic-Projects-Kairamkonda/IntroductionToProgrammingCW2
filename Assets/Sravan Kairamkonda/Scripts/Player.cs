using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SilderRotationValue silderRotationValue;

    float tiltAngle; 

    private void Start()
    {
        transform.localEulerAngles = Vector3.zero;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        tiltAngle = silderRotationValue.SliderValue*Time.deltaTime;

        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Mouse X") * tiltAngle;
 
        transform.Rotate(0,0, tiltAroundZ);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
