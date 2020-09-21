using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] RectTransform stick = null;
    [SerializeField] Image Background = null;

    public float limit = 250f;
    public void OnPointerDown(PointerEventData eventData)
    {
        Background.color = Color.red;
        stick.anchoredPosition = ConverToLocal(eventData);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos = ConverToLocal(eventData);
        if (pos.magnitude > limit)
        {
            pos = pos.normalized * limit;
        }
        stick.anchoredPosition = pos;

        float x = pos.x / limit;
        float y = pos.y / limit;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Background.color = Color.gray;
        stick.anchoredPosition = Vector2.zero;
    }
    Vector2 ConverToLocal(PointerEventData eventData)
    {
        Vector2 newPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform as RectTransform,
            eventData.position,
            eventData.enterEventCamera,
            out newPos);
        return newPos;
    }
}
