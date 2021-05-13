using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{

    /*Dùng 1 hàm Cho mỗi Nhân Vật 
     If (int = ?) => hàm cần dùng trong If để thực hiện kich bản cần thiết*/
    public DialogueManager _dialogueManager;
    public void Openlv(int a)
    {
        Debug.LogError("NowPosition = " + _dialogueManager.Now_position);
        if (_dialogueManager.Now_position == a)
        {
            //SceneManager.LoadScene("testLV");
            StartCoroutine(DelayOpenlv());
        }

    }

    public IEnumerator DelayOpenlv()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("testLV");

    }
}
