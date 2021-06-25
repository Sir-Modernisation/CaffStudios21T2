using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurrenderStateController : MonoBehaviour
{
    /*Script that controls Surrender States (duh)
     * When the player "shouts" at an enemy, the enemy will go through a series of states, including an initial hands up surrender, dropping their gun (probably using physics)
     * and laying down to be arrested.
     * In future, Random number generation for factors like flash / concussive devices (not exactly police standard issue - but we want to encourage LL), 
     * target may also randomly ignore commands or false surrender Zero-Hour Style*/

    //also - this should be put on a humanoid target w/ animator

    //State Legend: 0 - Normal, 1 - Hands Up, 2 - Drop weapon, 3 - Lay Down

    public int state;
    Animator charAnim;
    float timer;

    void Start()
    {
        state = 0;
    }

    void Command()
    {
        print("command received:");
        if (state == 0)
        {
            state = 1;
            print("Hands Up");
            //animator state hands up
        }
        else if (state == 1)
        {
            state = 2;
            print("Drop Weapon");
            //animator state throw weapon
        }
        else if (state == 2)
        {
            state = 3;
            print("Get Down");
            //guess.
        }
        else if (state == 3)
        {
            print("already surrendered");
            //no anim change
        }

    }

    
    void Update()
    {
        // Will implement a timer here, if an enemy is left unattended for too long they will begin to revert to normal state - hazardous
    }
}
