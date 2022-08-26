using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeanTweenMainPanel : MonoBehaviour
{
    // Note: RS - Right Side,   LS - Left Side,  US - Upside, USD - Upside Down
    [SerializeField]
    private Button RSMainArrow;
    [SerializeField]
    private Button LSMainArrow;
    [SerializeField]
    private Button USMainArrow;
    [SerializeField]
    private Button USDViewingArrow;
    [SerializeField]
    private Button mainQuit;
    [SerializeField]
    private Button RSAchievementArrow;
    [SerializeField]
    private Button LSInfoArrow;

    // Start is called before the first frame update
    void Start()
    {
        RSMainArrow.gameObject.SetActive(true);
        LSMainArrow.gameObject.SetActive(true);
        RSAchievementArrow.gameObject.SetActive(false);
        LSInfoArrow.gameObject.SetActive(false);
        USDViewingArrow.gameObject.SetActive(false);
        mainQuit.gameObject.SetActive(true);
        USMainArrow.gameObject.SetActive(true);
    }


    private void activateMainUI()
    {
        RSMainArrow.gameObject.SetActive(true);
        LSMainArrow.gameObject.SetActive(true);
        mainQuit.gameObject.SetActive(true);
        USMainArrow.gameObject.SetActive(true);
    }

    private void deactivateMainUI()
    {
        RSMainArrow.gameObject.SetActive(false);
        LSMainArrow.gameObject.SetActive(false);
        mainQuit.gameObject.SetActive(false);
        USMainArrow.gameObject.SetActive(false);
    }


    public void mainPanelRight()
    {

        deactivateMainUI();
        LSInfoArrow.gameObject.SetActive(true);

        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(-722.6f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutExpo);

    }

    public void mainPanelLeft()
    {
        deactivateMainUI();
        RSAchievementArrow.gameObject.SetActive(true);

        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(722.6f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutExpo);  
    }

    public void mainPanelUp()
    {
        deactivateMainUI();
        USDViewingArrow.gameObject.SetActive(true);

        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(0f, -424f, 0f), .5f).setEase(LeanTweenType.easeOutExpo);  
    }

    public void viewingPanelDown()
    {
        activateMainUI();
        USDViewingArrow.gameObject.SetActive(false);
        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(0f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutExpo);
    }

    public void infoPanelLeft()
    {
        activateMainUI();
        LSInfoArrow.gameObject.SetActive(false);

        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(0f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutExpo);
    }

    public void AchievementPanelRight()
    {
        activateMainUI();
        RSAchievementArrow.gameObject.SetActive(false);

        LeanTween.move(this.gameObject.GetComponent<RectTransform>(), new Vector3(0f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutExpo);
  
    }
}
