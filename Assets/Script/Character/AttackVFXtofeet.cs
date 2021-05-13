using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackVFXtofeet : MonoBehaviour
{
    public GameObject VFX, Feet;

    // Update is called once per frame
    void Update()
    {
        VFX.transform.position = Feet.transform.position;
    }
}
