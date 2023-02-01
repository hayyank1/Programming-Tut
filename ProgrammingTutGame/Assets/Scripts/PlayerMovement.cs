using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * playerSpeed, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.up * -playerSpeed, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * playerSpeed, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -playerSpeed, ForceMode2D.Force);
        }
    }
}
