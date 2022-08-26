using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void OnApplicationQuit() 
    {
        PlayerPrefs.DeleteKey("HasGameStarted");
    }

    public void mainScene()
    {
        SceneManager.LoadScene(0);
    }

    public void versionScene()
    {
        SceneManager.LoadScene(1);
    }

    public void creditScene()
    {
        SceneManager.LoadScene(2);
    }

    public void quit()
    {
        Application.Quit();
    }

}
