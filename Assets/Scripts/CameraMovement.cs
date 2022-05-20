using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float mouseSensitivity  =100f;

    float xRotation =0f;

    float yRotation =0f;

    public Transform playerBody;


    public float speed   =50f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState  =CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") *mouseSensitivity *Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") *mouseSensitivity *Time.deltaTime;


        if (Input.GetKey(KeyCode.RightArrow))
        {
            mouseX = speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mouseX = -1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            mouseY = speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            mouseY = -1 * speed * Time.deltaTime;
        }

        xRotation -= mouseY;
        xRotation =Mathf.Clamp(xRotation,-45f,0f);
        transform.localRotation  = Quaternion.Euler(xRotation,-180f,0f);
        yRotation -= mouseX;
        if(yRotation>-180f && yRotation<180f)
        {
            playerBody.Rotate(Vector3.up*mouseX);
        }
        else{
            if(yRotation<-180f){
                yRotation =-180f;
            }
            if(yRotation>180f){
                yRotation =180f;
            }
        }
       
    }
}
