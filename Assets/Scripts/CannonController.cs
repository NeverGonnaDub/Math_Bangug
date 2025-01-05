using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float mouseSensitivity = 1f;
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");


        float horizontalMouseInput = Input.GetAxis("Mouse X");

        float firstCombinedInput = horizontalInput + (horizontalMouseInput * mouseSensitivity);

  
        RotateCannon(firstCombinedInput);
    }

    void RotateCannon(float input)
    {
        transform.Rotate(Vector3.up, input * rotationSpeed * Time.deltaTime);
    }
}