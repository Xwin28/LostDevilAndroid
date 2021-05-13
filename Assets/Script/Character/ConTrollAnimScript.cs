using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConTrollAnimScript : MonoBehaviour
{
    Animator _anim;
    BasicBehaviour _basic;
    MoveBehaviour _move;
    public ThirdPersonOrbitCamBasic _cam;
    public GameObject _Vic, _Die;
    public GameObject _VFXWin;
    public GameObject _locationVFX;
    public GameObject _BtnShoot;
    public Camera m_cam;
    // Start is called before the first frame update
    void Start()
    {
        _anim = gameObject.GetComponent<Animator>();
        _basic = gameObject.GetComponent<BasicBehaviour>();
        _move = gameObject.GetComponent<MoveBehaviour>();
    }

    bool doOne = true;
    public GameObject Key;
    public ChooseSFX _choose;
    public AudioPlayer _au;

    private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.CompareTag("PlayerShoot"))
        {
            _BtnShoot.SetActive(false);
        }
    }


    public void ShowADVideo()
    {

        if (Random.Range(0,2) == 0 && GoogleAdsManager.instanceAds.CheckRequestVideo())
        {
            GoogleAdsManager.instanceAds.ShowVideoAds();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("VIC"))
        {
            _choose.Choose_Sfx(9);
            Debug.Log("HIT VICC");
            _basic.enabled = false;
            _move.enabled = false;
            _cam.camOffset = new Vector3(0.4f, 0.5f, -3);
            _anim.SetTrigger("Vic");
            int i = Random.Range(0, 3);
            _anim.SetFloat("Victree", i);
            if(_Vic.activeSelf == false)
            _Vic.SetActive(true);
            Instantiate(_VFXWin, _locationVFX.transform.position, _locationVFX.transform.rotation);

        }
        else if(other.gameObject.CompareTag("KillPlayer"))
        {
            _choose.Choose_Sfx(10);
            _basic.enabled = false;
            _move.enabled = false;
            _anim.SetBool("Death", true);

            if(_Die.activeSelf == false)
            _Die.SetActive(true);

            ShowADVideo();
            //Time.timeScale = 0;
        }
        else if(other.gameObject.CompareTag("Death"))
        {
            if(doOne)
            {
                _au.StopMusic();
                doOne = false;
                if (_Die.activeSelf == false)
                    _Die.SetActive(true);

                StartCoroutine(delayPause());
            }

        }
        else if(other.gameObject.CompareTag("PlayerShoot"))
        {
            _BtnShoot.SetActive(true);
        }

        
        

        if(other.gameObject.CompareTag("Key"))
        {
            Key.SetActive(true);
        }
        if(other.gameObject.CompareTag("Door"))
        {
            Key.SetActive(false);
        }
    }

    IEnumerator delayPause()
    {
        Rigidbody _rb = gameObject.GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
        _anim.SetBool("Death", true);
        yield return new WaitForSeconds(1);
        ShowADVideo();
        Time.timeScale = 0;
    }

    public GameObject _Bullet;
    public void Shooting()
    {
        _anim.SetTrigger("Shoot");
        _basic.enabled = false;
        _move.enabled = false;
    }

    public void AnimShoot()
    {
        Instantiate(_Bullet, _locationVFX.transform.position, _locationVFX.transform.rotation);
        _choose.Choose_Sfx(17);

    }

    // put this end of Shooting Animation
    public void ResetShoot()
    {
        _basic.enabled = true;
        _move.enabled = true;
        GameObject.FindGameObjectWithTag("PlayerBlock").GetComponent<StoneShootDES>().DestroyThisStone();
    }
}
