using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItemScript : MonoBehaviour
{
    public GameObject[] Item;//Các Item Trong Phòng
    //Show Item Đã có trong phòng, các item chưa có không hiện
    void Start()
    {
        ShowItem();
    }

    public void ShowItem()
    {
        GameObject _all = GameObject.FindGameObjectWithTag("DATA");
        bool[] _temp = _all.GetComponent<AllInfor>().Phong_1;
        int y = _temp.Length;
        for (int i = 0; i < y; i++)
        {
            if (_temp[i])
            {
                Item[i].SetActive(true);
            }
            else
            {
                Item[i].SetActive(false);
            }
        }
    }
}
