using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCannonSript : MonoBehaviour
{
    public GameObject _VFX;
    public float rotateSpeed = 10, speed = 10;
    Vector3 _target;
    Rigidbody _rb;
    public ChooseSFX _choose;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(50, speed);
        _target = GameObject.FindGameObjectWithTag("Player").transform.position;

        _rb = gameObject.GetComponent<Rigidbody>();
        //StartCoroutine(delaySpeed());
    }

    IEnumerator delaySpeed()
    {
        yield return new WaitForSeconds(3);
        speed = 128;
        //Make Sure PlayerDeath
        yield return new WaitForSeconds(10);
        gameObject.transform.position = _target;
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
        if (other.gameObject.CompareTag("Player"))
        {
            _choose.Choose_Sfx();
            Instantiate(_VFX, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
        else
        if (other.gameObject.CompareTag("PlayerBlock"))
        {
            _choose.Choose_Sfx(19);
            Destroy(this.gameObject);
        }
    }
}
