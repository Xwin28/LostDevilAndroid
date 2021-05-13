using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshMovingTrigger : MonoBehaviour
{

    public GameObject[] _meshtoMove;
    
    public int MoveSpeed;
    public bool update;
    public float tolerance;
    public GameObject _TargetPoint;
    public void Start()
    {
        tolerance = MoveSpeed * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = transform;
            
            for (int i = 0; i < _meshtoMove.Length; i++)
            {
                update = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }

    private void Update()
    {
        if (update)
        {
            for (int i = 0; i < _meshtoMove.Length; i++)
            {
                Vector3 heading = _TargetPoint.transform.position - _meshtoMove[i].transform.position;
                //Debug.LogError("heading.magnitude = " + heading.magnitude);
                if (heading.magnitude <= 0.05)
                {
                    _meshtoMove[i].transform.position = _TargetPoint.transform.position;
                    update = false;
                }
                else
                _meshtoMove[i].transform.position += (heading / heading.magnitude) * MoveSpeed * Time.deltaTime;
                

               
            }
        }
    }
}


