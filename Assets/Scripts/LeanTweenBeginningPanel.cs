using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenBeginningPanel : MonoBehaviour
{
    public void exitBeginningPanel()
    {
        LeanTween.scale(this.gameObject.GetComponent<RectTransform>(), new Vector3(0f, 0f, 0f), 0.4f).setOnComplete(DeleteMe);
    }

    private void DeleteMe()
    {
        Destroy(this.gameObject);
    }


}
