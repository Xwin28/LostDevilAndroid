using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLaySoundCharater : MonoBehaviour
{
    public int index;




    public void Step()
    {

        GameObject audioPlayer = GameObject.FindGameObjectWithTag("FootStep");
        audioPlayer.GetComponent<AudioPlayer>().Playsfx(index);


    }

    public void Step(int index)
    {
        GameObject audioPlayer = GameObject.FindGameObjectWithTag("FootStep");
        audioPlayer.GetComponent<AudioPlayer>().Playsfx(index);

    }
}
