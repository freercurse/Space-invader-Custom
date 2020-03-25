using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float thrust = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-thrust, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            rb.AddForce(thrust, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(thrust, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rb.AddForce(-thrust, 0, 0);
        }

    }
}
