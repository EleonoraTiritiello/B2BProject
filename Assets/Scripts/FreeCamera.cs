using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public Transform lookAt;
    public VirtualJoystick cameraJoystick;
    [SerializeField]
    private float distance = 10f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    public float sensitivityX = 3f;
    public float sensitivityY = 1f;

    private void Start()
    {
        transform.position = new Vector3(0, 1, 0);
    }

    private void Update()
    {
        currentX += cameraJoystick.inputDirection.x * sensitivityX;
        currentY += -cameraJoystick.inputDirection.z * sensitivityY;
    }
    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = lookAt.position + rotation * dir;
        transform.LookAt(lookAt);
    }
}
