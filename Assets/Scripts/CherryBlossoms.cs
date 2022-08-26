using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryBlossoms : MonoBehaviour
{
    private static GameObject cherryBlossoms;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (cherryBlossoms == null)
        {
            cherryBlossoms = this.gameObject; // In first scene, make us the singleton.
        }
        else
        {
            Destroy(gameObject); // On reload, singleton already set, so destroy duplicate.
        }
    }

}
