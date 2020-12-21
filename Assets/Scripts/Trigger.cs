using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] 
    private es esScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            esScript.Show = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            esScript.Show = false;
        }
    }
}
