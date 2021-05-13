
using SimpleInputNamespace;
using UnityEngine;
using UnityEngine.UI;

public class SettingOpenClose : MonoBehaviour
{
    
    public void Open()
    {

        if (GameObject.FindGameObjectWithTag("joy"))
        {
            for(int i=0;i< GameObject.FindGameObjectsWithTag("joy").Length;i++)
            {
                if (GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<Joystickk>())
                {
                    GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<Joystickk>().enabled = false;
                }
                else if (GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<CamJoyStick>())
                {
                    GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<CamJoyStick>().enabled = false;
                }
                GameObject.FindGameObjectsWithTag("parJoy")[i].GetComponent<Image>().raycastTarget = false;
            }
            /*//Debug.Log("FINED Open " + GameObject.FindGameObjectWithTag("joy").GetComponent<Joystick>().name);
            GameObject.FindGameObjectWithTag("joy").GetComponent<Joystickk>().enabled = false;
            GameObject.FindGameObjectWithTag("parJoy").GetComponent<Image>().raycastTarget = false;*/
        }

    }

    public void Close()
    {


        if (GameObject.FindGameObjectWithTag("joy"))
        {

            for (int i = 0; i < GameObject.FindGameObjectsWithTag("joy").Length; i++)
            {
                if(GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<Joystickk>())
                {
                    GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<Joystickk>().enabled = true;
                }
                else if(GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<CamJoyStick>())
                {
                    GameObject.FindGameObjectsWithTag("joy")[i].GetComponent<CamJoyStick>().enabled = true;
                }
                
                GameObject.FindGameObjectsWithTag("parJoy")[i].GetComponent<Image>().raycastTarget = true;
            }

        }


    }
}
