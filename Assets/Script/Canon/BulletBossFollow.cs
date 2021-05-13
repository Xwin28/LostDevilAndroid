using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBossFollow : MonoBehaviour
{
    public GameObject _VFX;
    public float rotateSpeed = 10, speed = 10;
    GameObject _target;
    Rigidbody _rb;
    public ChooseSFX _choose;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(10, speed);
        _target = GameObject.FindGameObjectWithTag("Player");
        _rb = gameObject.GetComponent<Rigidbody>();
        StartCoroutine(DelayDESTROY());
    }

    IEnumerator DelayDESTROY()
    {
        
        yield return new WaitForSeconds(Random.Range(2,6));
        _choose.Choose_Sfx();
        Instantiate(_VFX, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(this.gameObject);
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
