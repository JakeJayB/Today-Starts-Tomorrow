using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class InfoScreenUI : MonoBehaviour
{

    [SerializeField]
    private Text songNameText;
    [SerializeField]
    private Text errorMessage;
    [SerializeField]
    private Text highestStreakText;
    [SerializeField]
    private GameObject setStreakPanel;
    private MusicSource musicSource;

    void Start()
    {
        musicSource = GameObject.Find("Audio Source").GetComponent<MusicSource>();
        if(musicSource == null)
        {
            Debug.LogError("Music Source is NULL");
        }

    }

    void Update()
    {
        songNameText.text = "Currently Playing:\n" + musicSource.getSongName();
    }


    public void openLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/jacob-j-bejarano-74347b230/");
    }

    public void openGitHub()
    {
        Application.OpenURL("https://github.com/JakeJayB");
    }

    public void activateSetStreakPanel()
    {
        setStreakPanel.SetActive(true);
    }
    
    public void deactivateSetStreakPanel()
    {
        setStreakPanel.SetActive(false);
    }
    
    public void changeHighestStreak(string newStreak)
    {
        if(newStreak == "")
        {
            return;
        }

        int streakPlaceholder;
        streakPlaceholder = int.Parse(newStreak);
    
        if(streakPlaceholder < 0)
        {
            errorMessage.gameObject.SetActive(true);
            return;
        }
        else
        {
            PlayerPrefs.SetInt("Highest Streak", streakPlaceholder);
            highestStreakText.text = "Highest Streak: " + streakPlaceholder;
            errorMessage.gameObject.SetActive(false);
            deactivateSetStreakPanel();
        }

    }
}
