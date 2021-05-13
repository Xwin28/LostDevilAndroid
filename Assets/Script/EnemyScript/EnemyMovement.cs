using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    Animator _anim;
    public bool _update = false;
    public GameObject back, front, left, right, up, down, center;
    public GameObject _bullet, _bulletFolow;
    public ChooseSFX _SFX;
    public GameObject platformShoot;
    public int heal = 5;
    public GameObject _ENDINGShow,_SFXShow;
    public Transform SpawnEndPoint;
    public GameObject _Item;
    public GoogleAchiement _achiement;
    public GameObject Dialog;
    bool _end = true;// is take all Item
    
    #region DirectionSkill
    public void CastCenter()
    {
        // Back ==> x,y
        int _ammoNumber = Random.Range(2, 10);
        for (int i = 0; i < _ammoNumber; i++)
        {
            Instantiate(_bullet, center.transform.position, back.transform.rotation);
        }
        _SFX.Choose_Sfx();
    }


    public void CastBack()
    {
        // Back ==> x,y
        int _ammoNumber = Random.Range(2, 10);


        for (int i = 0; i < _ammoNumber; i++)
        {
            int _tenp = Random.Range(1, 5);
            float x = 0;
            float y = 0;
            float z = 0;
            switch (_tenp)
            {
                case 1:
                    x = (back.transform.position.x + Random.Range(2, 100));
                    y = back.transform.position.y + Random.Range(2, 100);
                    z = back.transform.position.z;
                    break;
                case 2:
                    x = (back.transform.position.x - Random.Range(2, 100));
                    y = back.transform.position.y - Random.Range(2, 100);
                    z = back.transform.position.z;
                    break;
                case 3:
                    x = (back.transform.position.x + Random.Range(2, 100));
                    y = back.transform.position.y - Random.Range(2, 100);
                    z = back.transform.position.z;
                    break;
                case 4:
                    x = (back.transform.position.x - Random.Range(2, 100));
                    y = back.transform.position.y + Random.Range(2, 100);
                    z = back.transform.position.z;
                    break;

            }

            Vector3 _pos = new Vector3(x, y, z);

            if (Random.Range(1, 3) == 1)
            {
                Instantiate(_bulletFolow, _pos, front.transform.rotation);
            }
            else
                Instantiate(_bullet, _pos, front.transform.rotation);

            if (_tenp == 2 || _tenp == 3)
                if (GameObject.FindGameObjectsWithTag("Item").Length < 10)
                    Instantiate(_Item, _pos, new Quaternion(0, 0, 0, 0));
        }

        _SFX.Choose_Sfx();
    }

    public void CastFront()
    {
        // front ==> x,y
        int _ammoNumber = Random.Range(2, 10);

        for (int i = 0; i < _ammoNumber; i++)
        {
            int _tenp = Random.Range(1, 5);
            float x = 0;
            float y = 0;
            float z = 0;
            switch (_tenp)
            {
                case 1:
                    x = (front.transform.position.x + Random.Range(2, 100));
                    y = front.transform.position.y + Random.Range(2, 100);
                    z = front.transform.position.z;
                    break;
                case 2:
                    x = (front.transform.position.x - Random.Range(2, 100));
                    y = front.transform.position.y - Random.Range(2, 100);
                    z = front.transform.position.z;
                    break;
                case 3:
                    x = (front.transform.position.x + Random.Range(2, 100));
                    y = front.transform.position.y - Random.Range(2, 100);
                    z = front.transform.position.z;
                    break;
                case 4:
                    x = (front.transform.position.x - Random.Range(2, 100));
                    y = front.transform.position.y + Random.Range(2, 100);
                    z = front.transform.position.z;
                    break;

            }

            Vector3 _pos = new Vector3(x, y, z);
            Instantiate(_bullet, _pos, front.transform.rotation);
            if (_tenp == 2 || _tenp == 3)
                if (GameObject.FindGameObjectsWithTag("Item").Length < 10)
                    Instantiate(_Item, _pos, new Quaternion(0, 0, 0, 0));
        }
        _SFX.Choose_Sfx();
    }


    public void CastLeft()
    {
        // left ==> z,y
        int _ammoNumber = Random.Range(2, 10);

        for (int i = 0; i < _ammoNumber; i++)
        {
            int _tenp = Random.Range(1, 5);
            float x = 0;
            float y = 0;
            float z = 0;
            switch (_tenp)
            {
                case 1:
                    x = left.transform.position.x;
                    y = left.transform.position.y + Random.Range(2, 100);
                    z = left.transform.position.z + Random.Range(2, 100);
                    break;
                case 2:
                    x = left.transform.position.x;
                    y = left.transform.position.y - Random.Range(2, 100);
                    z = left.transform.position.z - Random.Range(2, 100);
                    break;
                case 3:
                    x = left.transform.position.x;
                    y = left.transform.position.y - Random.Range(2, 100);
                    z = left.transform.position.z + Random.Range(2, 100);
                    break;
                case 4:
                    x = left.transform.position.x;
                    y = left.transform.position.y + Random.Range(2, 100);
                    z = left.transform.position.z - Random.Range(2, 100);
                    break;

            }

            Vector3 _pos = new Vector3(x, y, z);
            Instantiate(_bullet, _pos, left.transform.rotation);
            if (_tenp == 2 || _tenp == 3)
                if (GameObject.FindGameObjectsWithTag("Item").Length < 10)
                    Instantiate(_Item, _pos, new Quaternion(0, 0, 0, 0));
        }
        _SFX.Choose_Sfx();
    }


    public void CastRight()
    {
        // right ==> z,y
        int _ammoNumber = Random.Range(2, 10);

        for (int i = 0; i < _ammoNumber; i++)
        {
            int _tenp = Random.Range(1, 5);
            float x = 0;
            float y = 0;
            float z = 0;
            switch (_tenp)
            {
                case 1:
                    x = right.transform.position.x;
                    y = right.transform.position.y + Random.Range(2, 100);
                    z = right.transform.position.z + Random.Range(2, 100);
                    break;
                case 2:
                    x = right.transform.position.x;
                    y = right.transform.position.y - Random.Range(2, 100);
                    z = right.transform.position.z - Random.Range(2, 100);
                    break;
                case 3:
                    x = right.transform.position.x;
                    y = right.transform.position.y - Random.Range(2, 100);
                    z = right.transform.position.z + Random.Range(2, 100);
                    break;
                case 4:
                    x = right.transform.position.x;
                    y = right.transform.position.y + Random.Range(2, 100);
                    z = right.transform.position.z - Random.Range(2, 100);
                    break;

            }

            Vector3 _pos = new Vector3(x, y, z);
            if (Random.Range(1, 3) == 1)
            {
                Instantiate(_bulletFolow, _pos, front.transform.rotation);
            }
            else
                Instantiate(_bullet, _pos, front.transform.rotation);

            if (_tenp == 2 || _tenp == 3)
                if (GameObject.FindGameObjectsWithTag("Item").Length < 10)
                    Instantiate(_Item, _pos, new Quaternion(0, 0, 0, 0));
        }
        _SFX.Choose_Sfx();
    }

    public void CastUp()
    {
        // Up ==> x,z
        int _ammoNumber = Random.Range(2, 10);

        for (int i = 0; i < _ammoNumber; i++)
        {
            int _tenp = Random.Range(1, 5);
            float x = 0;
            float y = 0;
            float z = 0;
            switch (_tenp)
            {
                case 1:
                    x = up.transform.position.x + Random.Range(2, 100);
                    y = up.transform.position.y;
                    z = up.transform.position.z + Random.Range(2, 100);
                    break;
                case 2:
                    x = up.transform.position.x - Random.Range(2, 100);
                    y = up.transform.position.y;
                    z = up.transform.position.z - Random.Range(2, 100);
                    break;
                case 3:
                    x = up.transform.position.x - Random.Range(2, 100);
                    y = up.transform.position.y;
                    z = up.transform.position.z + Random.Range(2, 100);
                    break;
                case 4:
                    x = up.transform.position.x + Random.Range(2, 100);
                    y = up.transform.position.y;
                    z = up.transform.position.z - Random.Range(2, 100);
                    break;

            }

            Vector3 _pos = new Vector3(x, y, z);
            if (Random.Range(1, 3) == 1)
            {
                Instantiate(_bulletFolow, _pos, front.transform.rotation);
            }
            else
                Instantiate(_bullet, _pos, front.transform.rotation);
            if (_tenp == 2 || _tenp == 3)
                if (GameObject.FindGameObjectsWithTag("Item").Length < 10)
                    Instantiate(_Item, _pos, new Quaternion(0, 0, 0, 0));


        }
        _SFX.Choose_Sfx();
    }


    public void CastDown()
    {
        // Down ==> x,z
        int _ammoNumber = Random.Range(2, 10);

        for (int i = 0; i < _ammoNumber; i++)
        {
            int _tenp = Random.Range(1, 5);
            float x = 0;
            float y = 0;
            float z = 0;
            switch (_tenp)
            {
                case 1:
                    x = down.transform.position.x + Random.Range(2, 100);
                    y = down.transform.position.y;
                    z = down.transform.position.z + Random.Range(2, 100);
                    break;
                case 2:
                    x = down.transform.position.x - Random.Range(2, 100);
                    y = down.transform.position.y;
                    z = down.transform.position.z - Random.Range(2, 100);
                    break;
                case 3:
                    x = down.transform.position.x - Random.Range(2, 100);
                    y = down.transform.position.y;
                    z = down.transform.position.z + Random.Range(2, 100);
                    break;
                case 4:
                    x = down.transform.position.x + Random.Range(2, 100);
                    y = down.transform.position.y;
                    z = down.transform.position.z - Random.Range(2, 100);
                    break;

            }

            Vector3 _pos = new Vector3(x, y, z);
            if (Random.Range(1, 3) == 1)
            {
                Instantiate(_bulletFolow, _pos, front.transform.rotation);
            }
            else
                Instantiate(_bullet, _pos, front.transform.rotation);
            if (_tenp == 2 || _tenp == 3)
                if (GameObject.FindGameObjectsWithTag("Item").Length < 10)
                    Instantiate(_Item, _pos, new Quaternion(0, 0, 0, 0));



        }
        _SFX.Choose_Sfx();
    }
    #endregion


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerShoot"))
        {
            if(_end)
            {
                Dialog.SetActive(true);
                
            }
            else
            {
            _anim.SetTrigger("Hurt");
            heal = heal - 1;
            Debug.Log("Heal = " + heal);
                if (heal <= 0)
                {

                    AllInfor _all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
                    if (_all.GetA2() == false)
                    {
                        _all.setA2(true);
                        _achiement.UnlockAchiement(2);
                        _all.Save();
                    }

                    Rigidbody _rb = gameObject.GetComponent<Rigidbody>();
                    _rb.constraints = RigidbodyConstraints.None;
                    Debug.Log("Dea = " + heal);
                    StopCoroutine(delaypower());
                    _update = false;
                    _anim.SetBool("Death", true);

                    if (GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>().getSceneHellDone(15) == false)
                        StartCoroutine(delayshowend());
                }
            }
        }
    }



    IEnumerator delayshowend()
    {
        yield return new WaitForSeconds(1);
        _SFX.Choose_Sfx(23);
        Instantiate(_SFXShow, SpawnEndPoint.position, new Quaternion(0, 0, 0, 0));
        yield return new WaitForSeconds(2);
        Instantiate(_ENDINGShow, SpawnEndPoint.position, new Quaternion(0, 0, 0, 0));
    }
    // Start is called before the first frame update
    void Start()
    {
  
        // CHeck is take Full Item
        AllInfor all = GameObject.FindGameObjectWithTag("DATA").GetComponent<AllInfor>();
        bool[] _item = all.Phong_1;
        int _length = _item.Length;
        for(int i =0;i<_length; i++)
        {
            if(_item[i]==false)
            {
                _end = false;
                break;
            }
        }

         if(_end)
        {
            heal = 5;
            _anim = gameObject.GetComponent<Animator>();
            _anim.SetBool("sit",true);
        }
         else
        {
            heal = 5;
            _anim = gameObject.GetComponent<Animator>();
            _anim.SetTrigger("PowerUp");
        }


    }


    


    IEnumerator delaypower()
    {
        int _delayTime = Random.Range(3, 7);
        yield return new WaitForSeconds(_delayTime);
        if(!GameObject.FindGameObjectWithTag("PlayerBlock"))
        {
            int i = Random.Range(1, 5);
            switch(i)
            {
                case 1: Instantiate(platformShoot, back.transform.position, back.transform.rotation); break;
                case 2: Instantiate(platformShoot, front.transform.position, back.transform.rotation); break;
                case 3: Instantiate(platformShoot, left.transform.position, back.transform.rotation); break;
                case 4: Instantiate(platformShoot, right.transform.position, back.transform.rotation); break;
            }
         
        }
        int _temp = Random.Range(1, 10);
        _update = false;
        switch (_temp)
        {
            case 1:
                CastSkill_1();
                break;
            case 2:
                CastSkill_2();
                break;
            case 3:
                CastSkill_3();
                break;
            case 4:
                CastSkill_4();
                break;
            case 5:
                CastSkill_5();
                break;
            case 6:
                CastSkill_6();
                break;
            case 7:
                CastSkill_7();
                break;
            case 8:
                CastSkill_8(); ;
                break;
            case 9:
                CastSkill_9();
                break;

        }
    }

    public void resetUpdate()
    {
        Debug.Log("ResetUPDATE");
        StopCoroutine(delaypower());
        _update = true;
    }

    #region CastSkillAnim
    public void CastSkill_1()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 1);
    }

    public void CastSkill_2()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 2);
    }
    public void CastSkill_3()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 3);
    }
    public void CastSkill_4()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 4);
    }
    public void CastSkill_5()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 5);
    }
    public void CastSkill_6()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 6);
    }
    public void CastSkill_7()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 7);
    }
    public void CastSkill_8()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 8);
    }
    public void CastSkill_9()
    {
        _anim.SetTrigger("ATK");
        _anim.SetFloat("BlendSlot", 9);
    }
    #endregion
    // Update is called once per frame
    void Update()
    {
        if(_update)
        {
            _update = false;
            StartCoroutine(delaypower());

        }
    }

    public void SFX20_fall()
    {
        _SFX.Choose_Sfx(20);
    }
    public void SFX22_fall2()
    {
        _SFX.Choose_Sfx(22);
    }
    public void SFX21_roar()
    {
        _SFX.Choose_Sfx(21);
    }
}
