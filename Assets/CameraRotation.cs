using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [Min(0f)]
    [SerializeField]
    private float sensitivity = 5f;

    [Min(0f)]
    [SerializeField]
    private float maxYangle = 80f;

    private Vector3 rotationAxis;


    // Update is called once per frame
    private void Update()
    {
        UpdateRotationAxis();
    }

    private void FixedUpdate()
    {
        UpdateRotation();
    }

    private void UpdateRotationAxis()
    {
        rotationAxis.x += Input.GetAxis("Mouse X") * sensitivity;
        rotationAxis.y -= Input.GetAxis("Mouse Y") * sensitivity;
        //add buttons for Z axis
    }

    private void UpdateRotation()
    {
        var cameraTransform = Camera.main.transform;

        rotationAxis.x = Mathf.Repeat(rotationAxis.x, 360);
        rotationAxis.y = Mathf.Clamp(rotationAxis.y, -maxYangle, maxYangle);

        cameraTransform.rotation = Quaternion.Euler(rotationAxis.y, rotationAxis.x, 0);

    }
}
