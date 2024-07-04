using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ShoutingTouchScript : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent ShoutEvent;

    private Vector2 origin;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        ShoutEvent?.Invoke();
    }
}
