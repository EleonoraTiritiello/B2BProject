using UnityEngine;
using UnityEngine.UI;

public class Arrows : MonoBehaviour
{
    [SerializeField] private Button previous;
    [SerializeField] private Button next;

    private int currentBox;

    private void Awake()
    {
        SelectBox(0);
    }


    private void SelectBox(int _index)
    {
        previous.interactable = (_index != 0);
        next.interactable = (_index != transform.childCount - 1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void changeBox(int _change)
    {
        currentBox += _change;
        SelectBox(currentBox);
    }
}