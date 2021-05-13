using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCharcterUpScript : MonoBehaviour
{
    public float forceConst = 50;
    public bool _run = true;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && _run)
        {
            Debug.LogError("Jump");
            //other.gameObject.GetComponent<Rigidbody>().velocity = transform.up * forceConst;
            //other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * forceConst);
            //other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, other.gameObject.GetComponent<Rigidbody>().velocity.y,0) * forceConst, ForceMode.Impulse);;
            
            StartCoroutine(delayTrigger());
        }    
    }


    IEnumerator delayTrigger()
    {
        _run = false;
        yield return new WaitForSeconds(0.5f);
        _run = true;
    }
}
