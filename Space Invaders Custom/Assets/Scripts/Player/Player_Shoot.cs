using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public GameObject Lazer;
    public float shootForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = GameObject.Instantiate(Lazer, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.up * - shootForce);
        }
    }
}
