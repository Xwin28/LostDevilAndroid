using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFlatformScript : MonoBehaviour
{
    public float turnDegPerSec = 360;
    public Vector3 localAxis;
    protected float turnDegPerFrame;
    public bool _Upgrade;
    public ChooseSFX _choose;
    public bool Turn , run;
    public void Start()
    {

        run = true;
        Turn = true;
        turnDegPerFrame = turnDegPerSec * 0.02f;
    }

    public void Update()
    {
        if(_Upgrade)
        {

            if (Mathf.Abs(transform.rotation.y) >= 0.7071068f && Mathf.Abs(transform.rotation.y) <= 0.74 && run)
            {
                //_choose.Choose_Sfx();
                StartCoroutine(DelayStop());
                StartCoroutine(DelayRota());
            }
            else if (Mathf.Abs(transform.rotation.y) >= 0 && Mathf.Abs(transform.rotation.y) <= 0.03f && run)
            {
                //_choose.Choose_Sfx();
                StartCoroutine(DelayStop());
                StartCoroutine(DelayRota());
            }



            if (Turn)
            {
                transform.Rotate(localAxis, turnDegPerFrame);

            }
        }
       

    }

    IEnumerator DelayStop()
    {
        run = false;
        yield return new WaitForSeconds(1.5f);
        run = true;
    }
    IEnumerator DelayRota()
    {
        Turn = false;
        yield return new WaitForSeconds(1);
        Turn = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = transform;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
