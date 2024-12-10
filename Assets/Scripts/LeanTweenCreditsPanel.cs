using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenCreditsPanel : MonoBehaviour
{

    void Start() // Starting Y pos: -2028.943  // Ending Y Pos 2148.6
    {
        StartCoroutine(movePanelCoroutine());    
    }


    private IEnumerator movePanelCoroutine()
    {
        yield return new WaitForSeconds(3);
        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(0f, 2148.6f, 0f), 40f); //setEase(LeanTweenType.easeOutExpo)    
    }
}


