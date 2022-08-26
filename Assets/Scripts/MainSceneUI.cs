using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainSceneUI : MonoBehaviour
{
    [SerializeField]
    private Button successfulDayButton;
    [SerializeField]
    private Text dayCounterText;
    [SerializeField] 
    private Text highestStreakText;
    [SerializeField]
    private Button leftArrowButton;
    [SerializeField]
    private Button rightArrowButton;

    private int dayCounterNumber;
    private int highestStreakNumber;

    private void Start()
    {
        highestStreakNumber = PlayerPrefs.GetInt("Highest Streak");
        dayCounterNumber = PlayerPrefs.GetInt("Day Counter");
        highestStreakText.text = "Highest Streak: " + highestStreakNumber;
        dayCounterText.text = "Days Counted:\n" + dayCounterNumber;
    }

    private void changeDayCount()
    {
        dayCounterNumber = PlayerPrefs.GetInt("Day Counter");
        dayCounterText.text = "Days Counted:\n" + dayCounterNumber;
    }

    public void dayAdvance()
    {
        dayCounterNumber++;
        PlayerPrefs.SetInt("Day Counter", dayCounterNumber);
        changeDayCount();
    }

    public void setback()
    {
        //saving the progress and sending it to the highestStreak function before deleting it
        highestStreak(dayCounterNumber);
        PlayerPrefs.DeleteKey("Day Counter");
        changeDayCount();
    }

    private void highestStreak(int streak)
    {
        //if streak is higher than previous highest streak
        //set streak to highestStreakNumber
        if (streak > highestStreakNumber)
        {
            highestStreakNumber = streak;
            PlayerPrefs.SetInt("Highest Streak", highestStreakNumber);
            highestStreakText.text = "Highest Streak: " + highestStreakNumber;
        }
    }

    
    public void resetStreak()
    {
        PlayerPrefs.DeleteKey("Highest Streak");
        highestStreakNumber = PlayerPrefs.GetInt("Highest Streak");
        highestStreakText.text = "Highest Streak: " + highestStreakNumber;
    }
    
}
