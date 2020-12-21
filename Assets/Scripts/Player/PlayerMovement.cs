using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        Movements();
    }

    #region Movements

    void Movements()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
    #endregion
}
