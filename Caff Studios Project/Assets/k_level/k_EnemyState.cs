using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class k_EnemyState : MonoBehaviour
{
    public GameObject handcuffBarUI;
    public Image handcuffBar;
    public float currentHcLevel;
    public float maxHcLevel;

    public TMP_Text stunTimer;
    float stunTime = 5f;

    public bool stuning, chAction, arrested;

    float chTime = 0f;
    float startingTime = 2f;

    Animator anim;

    void Start()
    {
        arrested = false;
        currentHcLevel = 0f;
        chTime = startingTime;

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (chAction == false && stuning == false)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                chAction = true;
            }
        }

        if (chAction == false && stuning == false)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                stuning = true;
            }
        }


        if (chAction)
        {
            anim.SetBool("Handcuffing", true);
            handcuffBar.fillAmount = currentHcLevel / maxHcLevel;

            handcuffBarUI.SetActive(true);

            if (chTime > 0) ;
            {
                chTime -= 1 * Time.deltaTime;
                print(chTime);
            }
            if (chTime <= 0f)
            {
                chTime = 0f;
                Handcuff_Fail();
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                currentHcLevel += 1f;
            }

            if (currentHcLevel == maxHcLevel)
            {
                Handcuff_Success();
            }
        }

        if (stuning)
        {
            Stun();
        }

    }

    void Handcuff_Fail()
    {
        anim.SetBool("Handcuffing", false);
        handcuffBarUI.SetActive(false);
        chAction = false;
        Start();
    }

    void Handcuff_Success()
    {
        anim.SetBool("Handcuffing", false);
        anim.SetTrigger("Arrest");
        handcuffBarUI.SetActive(false);
        chAction = false;
        Start();
        arrested = true;
    }

    void Stun()
    {
        stunTime -= 1 * Time.deltaTime;
        stunTimer.text = stunTime.ToString("0");
        if (stunTime <= 0)
        {
            stunTimer.text = ("");
            stuning = false;
            stunTime = 5f;
        }
    }

}
