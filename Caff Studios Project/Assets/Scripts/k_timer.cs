using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class k_timer : MonoBehaviour
{

    float currentTime = 0f;
    float startTime = 0f;

    public TMP_Text t_Time;

    void Start()
    {
        currentTime = startTime;
    }

    void Timer()
    {
        currentTime -= 1 * Time.deltaTime;
        t_Time.text = currentTime.ToString("0");

        if (currentTime <= 0f)
        {
            t_Time.text = " ";
        }
    }


    void Update()
    {

        Timer();
        if (Input.GetKeyDown(KeyCode.M))
        {
          currentTime = 5f;        
        }

    }
}
