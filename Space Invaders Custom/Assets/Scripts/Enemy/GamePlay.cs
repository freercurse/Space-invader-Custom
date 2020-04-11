using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    public GameObject Enemy;
    public Text MyText;
    [SerializeField] int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        Loop();
        MyText.text = "" + points;
    }

    void Loop()
    {
        if (Enemy.tag == "dead")
        {
            points = points + 2;         

            
            Canvas.ForceUpdateCanvases();
        }
    }
}
