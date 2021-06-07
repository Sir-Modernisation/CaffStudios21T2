using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // A basic enemy controller for prototyping - will pick a random speed and direction every few seconds or so
    //To improve: Mkae sure it cant walk off an edge - Make it react when shot

    float speed1;
    float speed2;
    int maxTime;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print(Time.deltaTime); //get this working later
    }

    void Change()
    {
        speed1 = Random.Range(0, 10);
        speed2 = Random.Range(0, 10);
        maxTime = Random.Range(0, 5);
    }
}
