using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Training : MonoBehaviour
{
    public GameObject targetBoard1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B");
            Training1();
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("N");
            Training2();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("m");
            Quit();
        }
    }

    void Training1()
    {
        
        

    }


    void Training2()
    {
        
    }


    void Quit()
    {
        
    }

}
