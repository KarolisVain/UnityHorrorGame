using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Min(0f)]
    [SerializeField]
    private float moveSpeed = 8f;

    private Rigidbody rb;

    private Vector3 movementAxis;
    private Vector3 rotationAxis;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateMovementAxis();
    }

    private void FixedUpdate()
    {
        UpdatePosition();
    }

    private void UpdateMovementAxis()
    {
        movementAxis.x = Input.GetAxis("Horizontal");
        movementAxis.z = Input.GetAxis("Vertical");
    }

    private void UpdatePosition()
    {
        var posMovement = movementAxis * moveSpeed * Time.deltaTime;

        var currentPos = rb.position;
        var newPos = currentPos + posMovement;

        rb.MovePosition(newPos);
    }
}
