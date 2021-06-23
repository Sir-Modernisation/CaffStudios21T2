using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetBoard_a : MonoBehaviour
{
    

    public TMP_Text position;
    public TMP_Text description;
    public GameObject image;
    public List<Sprite> popImage;

    public GameObject head;
    public GameObject weaponHand;
    public GameObject body;
    public GameObject leg;
    public GameObject arm;

    public bool _head, _weaponhand, _body, _leg, _arm;


    void Start()
    {
        
    }

    IEnumerator Headshot()
    {
        position.text = "Headshot";
        description.text = "Object die, panic level and stress level rise++";
        image.GetComponent<Image>().sprite = popImage[0];

        yield return new WaitForSeconds(3);
        position.text = " ";
        description.text = " ";
        image.GetComponent<Image>().sprite = null;
    }

    IEnumerator Armshot()
    {
        position.text = "Arm";
        description.text = "Injure target";
        image.GetComponent<Image>().sprite = popImage[1];

        yield return new WaitForSeconds(3);
        position.text = " ";
        description.text = " ";
        image.GetComponent<Image>().sprite = null;
    }

    IEnumerator Bodyshot()
    {
        position.text = "Body";
        description.text = "Injure target";
        image.GetComponent<Image>().sprite = popImage[1];

        yield return new WaitForSeconds(3);
        position.text = " ";
        description.text = " ";
        image.GetComponent<Image>().sprite = null;
    }

    IEnumerator Legshot()
    {
        position.text = "Leg";
        description.text = "Injure target and target cannot move";
        image.GetComponent<Image>().sprite = popImage[2];

        yield return new WaitForSeconds(3);
        position.text = " ";
        description.text = " ";
        image.GetComponent<Image>().sprite = null;
    }

    IEnumerator WaeopnArmshot()
    {
        position.text = "Arm (with weapon)";
        description.text = "Injure target and the target drop the weapon";
        image.GetComponent<Image>().sprite = popImage[3];

        yield return new WaitForSeconds(3);
        position.text = " ";
        description.text = " ";
        image.GetComponent<Image>().sprite = null;
    }

    void Update()
    {
        if (transform.position.x >= 8)
        {
            transform.position = transform.position + new Vector3(-0.005f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(Armshot());
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            StartCoroutine(Bodyshot());
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(Headshot());
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            StartCoroutine(Legshot());
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(WaeopnArmshot());
        }

    }

}
