using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{

    private float duration = 3f;

    private void Awake() 
    {
       bool hasGameStarted = PlayerPrefs.GetInt("HasGameStarted") == 0 ? false : true;
       Debug.Log("Inside Awake");
       if(hasGameStarted)
       {
            Destroy(this.gameObject.transform.parent.gameObject);
       }
        PlayerPrefs.SetInt("HasGameStarted", 1);
       
    }

    void Start()
    {
        LeanTween.alpha(this.gameObject.GetComponent<RectTransform>(), 0f, 3f).setOnComplete(DeleteMe);
    }


    private void DeleteMe()
    {
        Destroy(this.gameObject);
    }
}
