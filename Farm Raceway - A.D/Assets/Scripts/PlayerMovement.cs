using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 3.0f;
    public Rigidbody rb;
    private Collider playerCollider;
    public float jumpForce = 5.0f;
    public bool isGrounded;
    public float turnSpeed = 100;
    float horizontal = 0;
    //public Vector3 direction = transform.forward;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*private void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(horizontal* turnSpeed * Time.fixedDeltaTime);

        // Multiply the current rotation by the change in rotation
        rb.MoveRotation(rb.rotation * deltaRotation);
    }*/

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(0, 0, vertical) * speed;
        //transform.Translate(movement);
        if (isGrounded)
        {
        rb.velocity = transform.forward * vertical * speed;
        }


        float rotation = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

        private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

    }




}
    






