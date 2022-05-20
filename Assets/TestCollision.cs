using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("CylinderCollision");
       transform.localScale -= new Vector3(1, 0, 1);
    }
}