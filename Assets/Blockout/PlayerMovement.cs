using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float rotationSpeed = 1f;
    public Vector3 MoveVector { set; get; }
    public VirtualJoystick joystick;
    public Transform cameraTransform;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        MoveVector = PoolInput();
        MoveVector = RotateWithView();
        Move();
    }
    private void Move()
    {
        rb.velocity = MoveVector * movementSpeed;
    }

    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;
        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();

        if (dir.magnitude > 1)
        {
            dir.Normalize();
        }
        return dir;

    }

    private Vector3 RotateWithView()
    {
        if (cameraTransform != null)
        {
            Vector3 dir = cameraTransform.TransformDirection(MoveVector);
            dir.Set(dir.x, 0, dir.z);
            return dir.normalized * MoveVector.magnitude;
        }
        else
        {
            cameraTransform = Camera.main.transform;
            return MoveVector;
        }
    }

}
