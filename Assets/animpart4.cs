using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animpart4 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "tool")
        {
            Debug.Log("CylinderCollision");
            transform.localScale -= new Vector3((float)0.005, 0, (float)0.005);
        }


    }
}
