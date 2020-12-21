using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOff : MonoBehaviour
{
    public GameObject player;
    public GameObject PicLimit;

    public bool Show;

    void Start()
    {
        Show = false;
    }

    void Update()
    {
        if (player.transform.position.z <= PicLimit.transform.position.z && player.transform.position.x >= PicLimit.transform.position.x)
        {
            Show = true;
        }
        else
            Show = false;
    }

}
