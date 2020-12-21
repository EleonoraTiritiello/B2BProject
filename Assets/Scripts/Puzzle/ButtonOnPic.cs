using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOnPic : MonoBehaviour
{
    public GameObject ButtonUi;
    public GameObject TextUi;
    public ShowOff EsScript;

    void Update()
    {
        check();
        // ButtonUi.SetActive(true);

    }

    void check()
    {
        if (EsScript.Show == false)
            ButtonUi.GetComponent<Image>().enabled = false;
        if (EsScript.Show == true)
            ButtonUi.GetComponent<Image>().enabled = true;
        if (EsScript.Show == false)
            TextUi.GetComponent<Text>().enabled = false;
        if (EsScript.Show == true)
            TextUi.GetComponent<Text>().enabled = true;
    }
}
