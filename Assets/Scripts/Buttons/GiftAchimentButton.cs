using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftAchimentButton : MonoBehaviour
{

   
    [SerializeField] private string Index;
    [SerializeField] private Questions questions;
    [SerializeField] private GameObject panel;
    public void OpenGift()
    {
        Calisartik(); 
        panel.SetActive(true);
    }
    public void CloseGift()
    {
        panel?.SetActive(false);
    }

    public void Calisartik()
    {
        if (Index == "a") questions.Achievements_Index = 0;
        else if (Index == "b") questions.Achievements_Index = 1;
        else if (Index == "c") questions.Achievements_Index = 2;
        else if (Index == "d") questions.Achievements_Index = 3;
        else if (Index == "e") questions.Achievements_Index = 4;
        else if (Index == "f") questions.Achievements_Index = 5;
        else if (Index == "g") questions.Achievements_Index = 6;
        else if (Index == "h") questions.Achievements_Index = 7;
        else if (Index == "i") questions.Achievements_Index = 8;
    }
}
