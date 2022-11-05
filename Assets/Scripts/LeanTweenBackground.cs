using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeanTweenBackground : MonoBehaviour
{
    [SerializeField]
    private float YMoveTime = 15f; // Was 15
    [SerializeField]
    private float ZRotationTime = 10f;
    [SerializeField]
    private float XMoveTime = 10f;
    
    private static GameObject background;



    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (background == null)
        {
            background = this.gameObject; // In first scene, make us the singleton.
        }
        else
        {
            Destroy(this.gameObject); // On reload, singleton already set, so destroy duplicate.
        }
    }


    private void Start() 
    {
        StartCoroutine(rotateZBackgroundCoroutine());
        StartCoroutine(moveYBackgroundCoroutine());
        StartCoroutine(MoveXBackgroundCoroutine());
    }
    

    private IEnumerator rotateZBackgroundCoroutine()
    {
        LeanTween.rotateZ(this.gameObject, 2f, 5f);
        yield return new WaitForSeconds(5f);

        while(true)
        {
            LeanTween.rotateZ(this.gameObject, -2f, ZRotationTime).setEase(LeanTweenType.easeInOutCubic);
            yield return new WaitForSeconds(ZRotationTime);
            LeanTween.rotateZ(this.gameObject, 2f, ZRotationTime).setEase(LeanTweenType.easeInOutCubic);
            yield return new WaitForSeconds(ZRotationTime);
        }
    }

    private IEnumerator moveYBackgroundCoroutine()
    {
        LeanTween.moveY(this.gameObject, 0.90f, 7f);
        yield return new WaitForSeconds(7.5f);

        while(true)
        {
            YMoveTime =  Random.Range(10f, 20f);
            LeanTween.moveY(this.gameObject, -0.90f, YMoveTime); //.setEase(LeanTweenType.easeInOutCubic)
            yield return new WaitForSeconds(YMoveTime);
            LeanTween.moveY(this.gameObject, 0.90f, YMoveTime);             
            yield return new WaitForSeconds(YMoveTime);
        }
    }

    private IEnumerator MoveXBackgroundCoroutine()
    {
        LeanTween.moveX(this.gameObject, .45f, 5f);
        yield return new WaitForSeconds(5f);

        while(true)
        {
            LeanTween.moveX(this.gameObject, -.45f, XMoveTime).setEase(LeanTweenType.easeInOutCubic);
            yield return new WaitForSeconds(XMoveTime);
            LeanTween.moveX(this.gameObject, .45f, XMoveTime).setEase(LeanTweenType.easeInOutCubic);
            yield return new WaitForSeconds(XMoveTime);
        }
    }
}



