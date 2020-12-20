using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Image JoystickBackgroundIMG;
    private Image JoystickIMG;
    [HideInInspector]
    public Vector3 inputDirection { set; get; }
    private void Start()
    {
        JoystickBackgroundIMG = GetComponent<Image>();
        JoystickIMG = transform.GetChild(0).GetComponent<Image>();
        inputDirection = Vector3.zero;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(JoystickBackgroundIMG.rectTransform,
            ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / JoystickBackgroundIMG.rectTransform.sizeDelta.x);
            pos.y = (pos.y / JoystickBackgroundIMG.rectTransform.sizeDelta.y);

            float x = (JoystickBackgroundIMG.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (JoystickBackgroundIMG.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;


            inputDirection = new Vector3(x, 0, y);
            inputDirection = (inputDirection.magnitude > 1.0f) ? inputDirection.normalized : inputDirection;

            JoystickIMG.rectTransform.anchoredPosition =
            new Vector3(inputDirection.x * (JoystickBackgroundIMG.rectTransform.sizeDelta.x / 3.5f),
            inputDirection.z * (JoystickBackgroundIMG.rectTransform.sizeDelta.y / 3.5f));
        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputDirection = Vector3.zero;
        JoystickIMG.rectTransform.anchoredPosition = Vector3.zero;
    }

    public float Horizontal()
    {
        if (inputDirection.x != 0)
        {
            return inputDirection.x;
        }
        else
        {
            return Input.GetAxis("Horizontal");
        }
    }
    public float Vertical()
    {
        if (inputDirection.z != 0)
        {
            return inputDirection.z;
        }
        else
        {
            return Input.GetAxis("Vertical");

        }

    }
}
