using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delayed_DeSpawn : MonoBehaviour
{
    public GameObject Lazer;
    [SerializeField] int delay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       StartCoroutine(isDeadYet());
    }

    IEnumerator isDeadYet()
    {
        yield return new WaitForSeconds(delay);
        DestroyObject(Lazer);

    }
}
