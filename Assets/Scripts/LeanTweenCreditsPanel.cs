using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenCreditsPanel : MonoBehaviour
{

    void Start() // original Y pos: -2028.943  // 2037.757
    {
        StartCoroutine(movePanelCoroutine());    
    }


    private IEnumerator movePanelCoroutine()
    {
        yield return new WaitForSeconds(3);
        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(0f, 2037.757f, 0f), 40f); //setEase(LeanTweenType.easeOutExpo)    
    }
}


