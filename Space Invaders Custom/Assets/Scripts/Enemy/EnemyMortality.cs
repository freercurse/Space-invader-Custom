using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyMortality : MonoBehaviour
{
    public Text thisText;
    int points;

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
            var text = thisText.GetComponent<Text>();
            
            points = Convert.ToInt32(text.text);
            points += 2;
            text.text = points.ToString();
            Debug.Log(points);
            Canvas.ForceUpdateCanvases();

            UnityEngine.Object.Destroy(this.gameObject); 
        }
    }

    

}
