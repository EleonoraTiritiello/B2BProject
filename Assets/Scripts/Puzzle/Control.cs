using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    private void FixedUpdate()
    {

        Check();
        if (Check() == true)
        {
            transform.GetChild(8).gameObject.SetActive(true);
            for (int i = 0; i < gameObject.transform.childCount; i++)
                gameObject.transform.GetChild(i).GetComponent<Movement>().isSelectable = false;

        }
    }
    public bool Check()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (gameObject.transform.GetChild(i).GetComponent<Movement>().rightPosition == false)
                return false;
        }
        return true;
    }
}
