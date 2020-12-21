using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCamera : MonoBehaviour
{
    public float mSensibility = 100f;
    public Transform player;
    bool CursorLocked;

    float xRotation = 0;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CursorLocked == false)
        {
            Cursor.lockState = CursorLockMode.None;
            CursorLocked = true;
        }else
        {
            if(Input.GetKeyDown(KeyCode.Space) && CursorLocked == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
                CursorLocked = false;
            }
        }

        if (CursorLocked == false)
        {
            float mouseX = Input.GetAxis("Mouse X") * mSensibility * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mSensibility * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            player.Rotate(Vector3.up * mouseX);
        }
    }
}