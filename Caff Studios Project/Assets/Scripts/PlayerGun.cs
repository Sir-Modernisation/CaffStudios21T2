using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    //Script to control the players gun - initially getting raycasting shots working, Then will also be responsible for Animations, Tracking the number of rounds fired, Scope, etc

    int mag;
    public Material Material1;
    public GameObject pistol;
    Animator anim;
    void Start()
    {
        mag = 5;
        anim = pistol.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //-Section: Managing wether the gun can be fired or needs to be reloaded-
        if (Input.GetButtonDown("Fire1"))
        {
            if(mag != 0)
            {
                Shoot();
            }
            else
            {
                print("Click!");
            }

        }
        if (Input.GetKeyDown("r"))
        {
            if (mag != 5)
            {
                {
                    anim.SetTrigger("Reloading");
                    anim.SetTrigger("Reloading");
                    print("Reloading:");
                    for (int i=mag; i<5; ++i)
                    {
                        print("chk");
                    }
                    mag = 5;
                }
            }
            else
            {
                print("full");
            }
        }
    }
    //--------------------------------------------------------------
    void Shoot()
    {
        print("Bang!");
        mag = mag - 1;
        //playanimation shoot or something
        if (mag == 0)
        {
            //play slide lock
            anim.SetTrigger("FireLast");
        }
        else
        {
            anim.SetTrigger("Fire");
            anim.SetTrigger("Fire");// shoots - have to do twice to unflag the trigger, else animation repeats
        }
        //Raycast here
        RaycastHit hit;
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            hit.transform.gameObject.GetComponent<Renderer>().material = Material1;
        }
    }

    //-------------------------------------------------------------


}
