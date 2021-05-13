using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSFX : MonoBehaviour
{
    public int index;

    public void Choose_Sfx()
    {

        GameObject audioPlayer = GameObject.FindGameObjectWithTag("SFXplayer");
        audioPlayer.GetComponent<AudioPlayer>().Playsfx(index);


    }




    public void Choose_Sfx(int index)
    {
        GameObject audioPlayer = GameObject.FindGameObjectWithTag("SFXplayer");
        audioPlayer.GetComponent<AudioPlayer>().Playsfx(index);

    }



    public void S_Choose_Sfx()
    {

        GameObject audioPlayer = GameObject.FindGameObjectWithTag("SFXplayer");
        audioPlayer.GetComponent<AudioPlayer>().S_Playsfx(index);


    }


    public void S_Choose_Sfx(int index)
    {
        GameObject audioPlayer = GameObject.FindGameObjectWithTag("SFXplayer");
        audioPlayer.GetComponent<AudioPlayer>().S_Playsfx(index);

    }
}
