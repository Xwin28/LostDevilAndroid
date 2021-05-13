using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BtnPlay : MonoBehaviour
{
    private bool IsPointerOverUIObject()// On only Touch UI not Touch Screen
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    public ChooseSFX sfx;
    public string loadlevel = "MainHouse";

    
    private void OnMouseDown()
    {
        if(IsPointerOverUIObject() == false)
        {
            Debug.LogError("Play");
            Openlevel();
            sfx.Choose_Sfx();
        }


    }

    

    public GameObject levelloading;
    public void Openlevel()
    {
        levelloading.GetComponent<LoadingScreenScript>().LoadLevel(loadlevel);
    }
}
