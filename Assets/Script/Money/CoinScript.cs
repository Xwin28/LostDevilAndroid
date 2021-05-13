using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float RotationSpeed;
    public int coin;
    public GameObject parentActor;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * (RotationSpeed * Time.deltaTime));
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            int _tempcoin = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getCoin();
            GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().setCoin(_tempcoin + coin);
            Destroy(parentActor);

        }
    }
}
