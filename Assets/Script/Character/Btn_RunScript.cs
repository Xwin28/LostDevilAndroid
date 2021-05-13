using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Btn_RunScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public BasicBehaviour _basic;

    public void OnPointerDown(PointerEventData eventData)
    {
        _basic.sprint = true;
    }




    public void OnPointerUp(PointerEventData eventData)
    {
        _basic.sprint = false;
    }


}

