using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es : MonoBehaviour
{
    public GameObject player;
    public GameObject PicLimit;
    public Camera camera;

    public bool Show;

    void Start()
    {
        Show = false;
    }

    /* void Update()
    {
        RaycastHit hit;
        Ray ray =  camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && player.transform.position.z >= PicLimit.transform.position.z)
        {
            //Debug.Log("ahhhhhhhhhhhhhahahah");
            Show = true;
        }
        else
            Show = false;
    } */

}
