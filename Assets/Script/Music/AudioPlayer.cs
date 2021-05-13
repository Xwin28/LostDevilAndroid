using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class AudioPlayer : MonoBehaviour
{
    [System.Serializable]
    public struct TileOverride
    {
        public TileBase tile;
        public AudioClip[] clips;
    }

    public AudioClip[] clips;

    public TileOverride[] overrides;

    public bool randomizePitch = false;
    public float pitchRange = 0.2f;

    protected AudioSource m_Source;
    protected Dictionary<TileBase, AudioClip[]> m_LookupOverride;

    private void Awake()
    {

        m_Source = GetComponent<AudioSource>();
        m_LookupOverride = new Dictionary<TileBase, AudioClip[]>();

        for (int i = 0; i < overrides.Length; ++i)
        {
            if (overrides[i].tile == null)
                continue;

            m_LookupOverride[overrides[i].tile] = overrides[i].clips;
        }
    }

    public void Start()
    {
        GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
        int temp = allinfor.GetComponent<AllInfor>().getMusic();

        /*if (this.gameObject.name == "MusicPlayer")
            Playmusic(temp);*/
    }


    // Fade in MUSIC
    public IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = targetVolume - 0.5f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

    //Fade Out
    public IEnumerator StartFadeOut(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = targetVolume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, 0, currentTime / duration);
            yield return null;
        }
        audioSource.Stop();
        yield break;
    }

    public void FadeOutMusic()
    {
        if (m_Source.isPlaying)
        {
            GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
            float tempM = allinfor.GetComponent<AllInfor>().getVolumeMusic();
            StartCoroutine(StartFadeOut(m_Source, 2, tempM));

        }
    }


    public void deVolume(float value)
    {
        m_Source.volume = value;
    }
    public void StopMusic()
    {
        m_Source.Stop();
    }

    public void PlayLoop()
    {
        
        AudioClip[] temp = clips;
        if (randomizePitch)
            m_Source.pitch = Random.Range(1.0f - pitchRange, 1.0f + pitchRange);
        m_Source.loop = true;
        m_Source.Play(0);
    }


    public void PlaymusicPlayer(int i)
    {
        m_Source.volume = 0.3f;
        m_Source.Stop();
        AudioClip[] temp = clips;
        if (i < temp.Length)
        {
            GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
            float tempM = allinfor.GetComponent<AllInfor>().getVolumeSfx();
            //StartCoroutine(StartFade(m_Source, 3, tempM));
            //m_Source.loop = true;
            m_Source.clip = temp[i];
            m_Source.Play(0);
        }

    }

    public void Playmusic(int i)
    {
        m_Source.volume = 1;
        m_Source.Stop();
        AudioClip[] temp = clips;
        if (i < temp.Length)
        {
            GameObject allinfor = GameObject.FindGameObjectWithTag("DATA");
            float tempM = allinfor.GetComponent<AllInfor>().getVolumeMusic();
            StartCoroutine(StartFade(m_Source, 3, tempM));
            //m_Source.loop = true;
            m_Source.clip = temp[i];
            m_Source.Play(0);
        }

    }


    public void S_Playsfx(int i)
    {
        m_Source.Stop();
        AudioClip[] temp = clips;
        if (randomizePitch)
            m_Source.pitch = Random.Range(1.0f - pitchRange, 1.0f + pitchRange);
        m_Source.PlayOneShot(temp[i]);

    }





    public void Playsfx(int i)
    {
        //m_Source.Stop();
        AudioClip[] temp = clips;
        if (randomizePitch)
            m_Source.pitch = Random.Range(1.0f - pitchRange, 1.0f + pitchRange);
        m_Source.PlayOneShot(temp[i]);

    }

    public void PlayRandomSound(TileBase surface = null)
    {
        AudioClip[] source = clips;

        AudioClip[] temp;
        if (surface != null && m_LookupOverride.TryGetValue(surface, out temp))
            source = temp;

        int choice = Random.Range(0, source.Length);

        if (randomizePitch)
            m_Source.pitch = Random.Range(1.0f - pitchRange, 1.0f + pitchRange);

        m_Source.PlayOneShot(source[choice]);
    }

    public void Stop()
    {
        m_Source.Stop();
    }
}

