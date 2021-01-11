using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour
{
    public Transform[] character;
    public InputField Level;
    public Transform Lock;
    public Button Previous;
    public Button Next;
    public Button SelectBtn;
    public Button Selected;
    private int[] charLevel = {0,50,200,500};
    private int currentChar;
    private int finalChar;
    private int finalLevel;
    void Start()
    {

    }
     void Update()
    {
        Previous.interactable = currentChar!=0;
        Next.interactable = currentChar!=transform.childCount-1;
        if(character[finalChar]==character[currentChar])
        {
            Selected.gameObject.SetActive(true);
        }
        else
        {
            Selected.gameObject.SetActive(false);
        }

        if(Level.text.Length!=0)
        finalLevel = int.Parse(Level.text);
        //else
        //finalLevel=0;
        
        if(finalLevel>=charLevel[currentChar])
        {
            SelectBtn.interactable=true;
            SelectBtn.GetComponentInChildren<Text>().text="Select";
            Lock.gameObject.SetActive(false);
        }
        else
        {
            SelectBtn.interactable=false;
            SelectBtn.GetComponentInChildren<Text>().text="Level "+(charLevel[currentChar]).ToString();
            Lock.gameObject.SetActive(true);
            Selected.gameObject.SetActive(false);
        }
    }

     public void SwitchCharacter(int index)
    {
        for(int i=0;i<transform.childCount;i++)
        {
            character[i].gameObject.SetActive(i==index);
        }
    }   

     public void SelectCharacter(int pos)
    {
        currentChar+=pos;
        SwitchCharacter(currentChar);
    }

    public void Select()
    {
        finalChar=currentChar;
    }
}
