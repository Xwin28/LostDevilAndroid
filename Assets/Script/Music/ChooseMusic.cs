using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseMusic : MonoBehaviour
{
    public int index;

    private void Start()
    {
        GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
        int i = allinfor.GetComponent<AllInfor>().getMusic();
        GameObject audioPlayer = GameObject.FindGameObjectWithTag("MusicPlayer");
        //audioPlayer.GetComponent<AudioPlayer>().Playmusic(i);
    }

    public void Choose_Music()
    {
        GameObject audioPlayer = GameObject.FindGameObjectWithTag("MusicPlayer");
        audioPlayer.GetComponent<AudioPlayer>().Playmusic(index);
        GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
        allinfor.GetComponent<AllInfor>().setMusic(index);
    }

    public void Choose_Next_Music()
    {

        GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
        int i = allinfor.GetComponent<AllInfor>().getMusic();

        if(i+1 >=14)
        { i = 0; }

        GameObject audioPlayer = GameObject.FindGameObjectWithTag("MusicPlayer");
        audioPlayer.GetComponent<AudioPlayer>().Playmusic(i + 1);
        allinfor.GetComponent<AllInfor>().setMusic(i + 1 );
        allinfor.GetComponent<AllInfor>().Save();
    }

}
