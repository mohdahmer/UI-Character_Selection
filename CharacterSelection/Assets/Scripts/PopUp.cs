using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public void callUp()
    {
        LeanTween.moveY(gameObject.GetComponent<RectTransform>(), 0f, 0.8f).setEase(LeanTweenType.easeSpring);
    }

    public void callDown()
    {
        LeanTween.moveY(gameObject.GetComponent<RectTransform>(), -600f, 0.8f).setEase(LeanTweenType.easeSpring);
    }
}
