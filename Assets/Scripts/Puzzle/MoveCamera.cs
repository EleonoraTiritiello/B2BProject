using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float NewPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            transform.position = new Vector3(transform.position.x + NewPosition, 1, -5.141f);
        if (Input.GetKeyDown(KeyCode.O))
            transform.position = new Vector3(transform.position.x - NewPosition, 1, -5.141f);
    }
}
