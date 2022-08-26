
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSource : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] musicClips;
    private static AudioSource musicSource;

    private bool wasFirstSongSelected = false;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (musicSource == null)
        {
            musicSource = GetComponent<AudioSource>(); // In first scene, make us the singleton.
        }
        else
        {
            Destroy(this.gameObject); // On reload, singleton already set, so destroy duplicate.
        }
    }

    private void OnApplicationFocus(bool focusStatus) 
    {
        //Debug.Log("Focus Status: " + focusStatus);
        if(focusStatus == true)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    private void Start()
    {
        musicSource.volume = .2f;
        StartCoroutine(FadeIn());
    }

    void Update()
    {
        if (Time.timeScale == 1 && !musicSource.isPlaying)
        {
            musicSource.clip = GetRandomClip();
            musicSource.Play();
        }
    }

    private AudioClip GetRandomClip()
    {
        AudioClip music = null;
        music = musicClips[Random.Range(0, musicClips.Length)];

        while (music == musicSource.clip)
        { 
            music = musicClips[Random.Range(0, musicClips.Length)];
        }

        if(wasFirstSongSelected != true)
        {
            wasFirstSongSelected = true;
        }
        
        return music;
    }

    private IEnumerator FadeIn()
    {
        while (musicSource.volume != 1)
        {
            musicSource.volume += 1 * Time.deltaTime / 15; // fading in song for 15 seconds
            //Debug.Log(Time.time);
            yield return null;
        }
    }

    public string getSongName()
    {
        if(wasFirstSongSelected == true)
        {
            return musicSource.clip.name.ToString();
        }
        else
        {
            return "Song N/A";
        }
    }

}