using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyGameplay : MonoBehaviour
{
    public int points = 0;
    public GameObject pointsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Projectile")
        {
            DestroyObject(this.gameObject);

            points = points + 2;
            setScore();
        }
    }

    public void setScore()
    {
        Text pointsToDisplay = pointsDisplay.GetComponent<Text>();
        pointsToDisplay.text = points.ToString();
        Debug.Log(points.ToString());
        Debug.Log("points have been scored");
       
    }
}
