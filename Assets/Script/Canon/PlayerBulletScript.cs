using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    public GameObject _VFX;
    public float rotateSpeed = 10, speed = 10;
    Vector3 _target;
    Rigidbody _rb;
    public ChooseSFX _choose;
    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Enemy").transform.position;

        _rb = gameObject.GetComponent<Rigidbody>();

    }



    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (Vector3)_target - _rb.position;
        direction.Normalize();
        Vector3 rotateAmount = Vector3.Cross(direction, transform.forward);
        _rb.angularVelocity = -rotateAmount * rotateSpeed;
        _rb.velocity = transform.forward * speed;

        if (Vector3.Distance(transform.position, _target) <= 0.21f)
        {
            _choose.Choose_Sfx();
            Instantiate(_VFX, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            _choose.Choose_Sfx();
            Instantiate(_VFX, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
