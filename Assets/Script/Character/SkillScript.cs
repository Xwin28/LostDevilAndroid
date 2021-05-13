using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillScript : MonoBehaviour
{
    public GameObject run, jump, fly;
    // Start is called before the first frame update
    void Start()
    {
        AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        if(_all.isCanRun())
        {
            run.SetActive(true);
        }
        else
        {
            run.SetActive(false);
        }

        if (_all.isCanJump())
        {
            jump.SetActive(true);
        }
        else
        {
            jump.SetActive(false);
        }

        if (_all.isCanFly())
        {
            fly.SetActive(true);
        }
        else
        {
            fly.SetActive(false);
        }
    }

    public void Check()
    {
        AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        if (_all.isCanRun())
        {
            run.SetActive(true);
        }
        else
        {
            run.SetActive(false);
        }

        if (_all.isCanJump())
        {
            jump.SetActive(true);
        }
        else
        {
            jump.SetActive(false);
        }

        if (_all.isCanFly())
        {
            fly.SetActive(true);
        }
        else
        {
            fly.SetActive(false);
        }
    }
}
