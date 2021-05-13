using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshMoveAutomatic : MonoBehaviour
{
    public Vector3[] Point;
    public int Point_Number = 0;
    private Vector3 current_target;

    public float tolerance;
    public float speed;
    public float delay_time;

    private float delay_start;
    public bool automatic;

    // Start is called before the first frame update
    void Start()
    {
        if (Point.Length > 0)
        {
            current_target = Point[0];
        }
        tolerance = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != current_target)
        {
            MovePlatform();
        }
        else
        {
            UpdatePlatform();
        }
    }

    void MovePlatform()
    {
        Vector3 heading = current_target - transform.position;
        transform.position += (heading / heading.magnitude) * speed * Time.deltaTime;
        if(heading.magnitude <tolerance)
        {
            transform.position = current_target;
            delay_start = Time.time;
        }
    }
    void UpdatePlatform()
    {
        if(automatic)
        {
            if(Time.time - delay_start > delay_time)
            {
                NextPlatform();
            }
        }
    }

    public void NextPlatform()
    {
        Point_Number++;
        if(Point_Number >=  Point.Length)
        {
            Point_Number = 0;
        }
        current_target = Point[Point_Number];
    }



    private void OnTriggerEnter(Collider other)
    {
            other.transform.parent = transform;

    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
