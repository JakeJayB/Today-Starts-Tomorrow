using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ViewingPanelUI : MonoBehaviour
{
    [SerializeField]
    private Text dateText;
    [SerializeField]
    private Text songNameText;
    private MusicSource musicSource;

    void Start()
    {
        musicSource = GameObject.Find("Audio Source").GetComponent<MusicSource>();
        if(musicSource == null)
        {
            Debug.LogError("Music Source is NULL");
        }
    }

    // Update is called once per frame
    void Update()
    {
        displayCurrentDate();
        displayCurrentSong();


    }


    private void displayCurrentDate()
    {
        dateText.text = DateTime.Now.ToString();
    }

    private void displayCurrentSong()
    {
        songNameText.text = "Currently Playing: " + musicSource.getSongName();
    }
}