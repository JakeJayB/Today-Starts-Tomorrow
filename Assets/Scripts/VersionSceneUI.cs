using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VersionSceneUI : MonoBehaviour
{
    public void redirectToGithubOldVersion()
    {
        Application.OpenURL("https://github.com/JakeJayB/Tomorrow-Starts-Today/releases/tag/TST-0.2.0-beta");
    }
}
