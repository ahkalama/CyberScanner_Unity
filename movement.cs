using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public AudioSource footsound;
    public float moveSpeed = 5f;
    public float sprintSpeedMultiplier = 2f;

    private Rigidbody rb;
    private bool isMoving;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 moveVelocity = transform.TransformDirection(moveDirection) * moveSpeed;

        if (Mathf.Abs(verticalInput) > 0.1f || Mathf.Abs(horizontalInput) > 0.1f)
        {
            isMoving = true;
            if (!footsound.isPlaying)
            {
                footsound.Play();
            }
        }
        else
        {
            isMoving = false;
            footsound.Stop();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveVelocity *= sprintSpeedMultiplier;
        }

        transform.position += moveVelocity * Time.deltaTime;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 500f, ForceMode.Impulse);
        }
    }
}
