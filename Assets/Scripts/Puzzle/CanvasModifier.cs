using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasModifier : MonoBehaviour
{
    public GameObject canvas;
    public Camera MainCamera, DescriptionCamera;
    public Control Controls;

    private void Update()
    {
        CheckButtonTrue();
    }

    public void CheckButtonTrue()
    {
        if (Controls.Check() == true)
        {
            DescriptionCamera.enabled = true;
            MainCamera.enabled = false;
            canvas.SetActive(true);
        }
    }
}
