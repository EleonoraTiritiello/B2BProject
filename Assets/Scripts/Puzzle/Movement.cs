using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
	public GameObject Slot;
	float SlotX;
	float SlotY;
	public bool isSelectable = true;

	public bool rightPosition = false;

	public float rightPositionX;
	public float rightPositionY;

    private void Update()
    {
		if (gameObject.transform.localPosition.x == rightPositionX && gameObject.transform.localPosition.y == rightPositionY)
		{
			rightPosition = true;
		}
		else
			rightPosition = false;

	}
    void OnMouseUp()
	{
		if (Vector3.Distance(transform.position, Slot.transform.position) == 1 && isSelectable == true)
		{
			SlotX = transform.position.x;
			SlotY = transform.position.y;
			transform.DOMove(new Vector3(Slot.transform.position.x, Slot.transform.position.y, 0f), 0.25f);
			//transform.position = new Vector3(slot.transform.position.x, slot.transform.position.y, 0f);
			Slot.transform.position = new Vector3(SlotX, SlotY, 0f);
		}
	}
}