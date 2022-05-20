using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject part4;

    void Update()
    {
        if (Input.GetButtonDown("G"))
        {
            part4.GetComponent<Animator>().Play("SlideRightPart4");
        }
    }
}
