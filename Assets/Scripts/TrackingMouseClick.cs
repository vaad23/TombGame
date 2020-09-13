using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TrackingMouseClick : MonoBehaviour, IPointerDownHandler
{
    public event UnityAction Clicked;

    public void OnPointerDown(PointerEventData eventData)
    {
        Clicked?.Invoke();
    }
}
