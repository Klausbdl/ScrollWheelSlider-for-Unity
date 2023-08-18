using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollWheelSlider : MonoBehaviour
{
    Slider slider;
    public float scrollSensitivity = 1;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void ChangeValue(BaseEventData e)
    {
        slider.value += e.currentInputModule.input.mouseScrollDelta.y * scrollSensitivity;
    }
}
