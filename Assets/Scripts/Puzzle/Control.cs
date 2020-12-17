using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private void FixedUpdate()
    {
        cacca();
        if (cacca() == true)
        {
            Debug.Log("Hai vinto bamboccio adesso vai a giocare a cyberpunk");
            transform.GetChild(8).gameObject.SetActive(true);
            for (int i = 0; i < gameObject.transform.childCount; i++)
                gameObject.transform.GetChild(i).GetComponent<Movement>().isSelectable = false;


        }
    }
    private bool cacca()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (gameObject.transform.GetChild(i).GetComponent<Movement>().rightPosition == false)
                return false;
        }
        return true;
    }
}
