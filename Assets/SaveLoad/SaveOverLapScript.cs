using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOverLapScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("SAVEEE");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("SAVEEE");
            GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().Save();
        }    
    }
}
