using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileJoystick_UI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public RectTransform background = null;
    private RectTransform baseRect = null;

    private Canvas canvas;
    private Camera cam;
    public void Start()
    {
        baseRect = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        background.gameObject.SetActive(false);

    }
    /*public Vector2 ScreenPointToAnchoredPosition()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Update the Text on the screen depending on current position of the touch each frame
            return touch.position;
        }
        else if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            return Camera.main.ScreenToWorldPoint(mousePos);
        }
        return new Vector2(0, 0);
    }*/

    protected Vector2 ScreenPointToAnchoredPosition(Vector2 screenPosition)
    {
        Vector2 localPoint = Vector2.zero;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(baseRect, screenPosition, cam, out localPoint))
        {
            Vector2 pivotOffset = baseRect.pivot * baseRect.sizeDelta;
            return localPoint - (background.anchorMax * baseRect.sizeDelta) + pivotOffset;
        }
        return Vector2.zero;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
        background.gameObject.SetActive(true);
    }




    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Point UP");
        background.gameObject.SetActive(false);
        background.anchoredPosition = Vector2.zero;
    }
}

