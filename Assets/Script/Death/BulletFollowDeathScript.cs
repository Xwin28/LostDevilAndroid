using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletFollowDeathScript : MonoBehaviour
{
    public GameObject _VFX;
    public float rotateSpeed =10, speed=10;
    GameObject _target;
    Rigidbody _rb;
    public ChooseSFX _choose;
    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _rb = gameObject.GetComponent<Rigidbody>();
        StartCoroutine(delaySpeed());
    }

    IEnumerator delaySpeed()
    {
        yield return new WaitForSeconds(3);
        speed = 128;
        //Make Sure PlayerDeath
        yield return new WaitForSeconds(10);
        gameObject.transform.position = _target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (Vector3)_target.transform.position - _rb.position;
        direction.Normalize();
        Vector3 rotateAmount = Vector3.Cross(direction, transform.forward);
        _rb.angularVelocity = -rotateAmount * rotateSpeed;
        _rb.velocity = transform.forward * speed;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _choose.Choose_Sfx();
            Instantiate(_VFX, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
