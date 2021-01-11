﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSize2 : MonoBehaviour
{
    public void ScaleCharIn()
    {
        LeanTween.scale( gameObject, new Vector3(0f,0f,1f), 0.5f );
    }

    public void ScaleCharOut()
    {
        LeanTween.scale( gameObject, new Vector3(1f,1f,1f), 0.5f );
    }
}
