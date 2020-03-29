using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Player_Shoot : MonoBehaviour
{
    public GameObject Lazer;
    public float shootForce;
    public float timeBeforeShot = 0.4f;
    bool timer = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();

    }

   IEnumerator Timer ()
    {
        yield return new WaitForSeconds(timeBeforeShot);
        timer = true;
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timer == true)
        {
            GameObject shot = GameObject.Instantiate(Lazer, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.up * shootForce);
            timer = false;
            StartCoroutine(Timer());
        }
    }
}
