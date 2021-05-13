using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackVFXtoPlayerScript : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        Vector3 _temp = GameObject.FindGameObjectWithTag("Player").transform.position;
        gameObject.transform.position = _temp;
    }
}
