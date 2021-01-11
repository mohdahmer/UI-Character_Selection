using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAvatar : MonoBehaviour
{
    public InputField LevelText;
    public Transform[] LockLevel;
    private int[] Avatar = {0,50,200,500};
    private int FinalText;

    void Update()
    {
        for(int i=0;i<transform.childCount;i++)
        {
            if(LevelText.text.Length!=0)
            FinalText = int.Parse(LevelText.text);
            //else
            //FinalText=0;

            if(FinalText>=Avatar[i])
            {
                LockLevel[i].gameObject.SetActive(false);
            }
            else
            {
                LockLevel[i].gameObject.SetActive(true);
            }
        }
    }
}
