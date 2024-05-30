using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Achievement_Script : MonoBehaviour
{
    [SerializeField] private Questions questions;
    [SerializeField] private TextMeshProUGUI achimentText;
    [SerializeField] private Image star1, star2, star3, star4;
    [SerializeField] private Sprite fullstar, emptystar;
    private void FixedUpdate()
    {
        Getachivment();
        FillStars(setpercent());
    }

    private void Getachivment()
    {
        achimentText.text = questions.Achievements_String[questions.Achievements_Index];
    }
    private void FillStars(float percent)
    {
        if(percent>4)
        {
            star1.sprite = fullstar;
            star2.sprite = fullstar;
            star3.sprite = fullstar;
            star4.sprite = fullstar;
        }
        else if(percent <= 4 && percent >= 3)
        {
            star1.sprite = fullstar;
            star2.sprite = fullstar;
            star3.sprite = fullstar;
            star4.sprite = emptystar;
        }
        else if (percent <= 3 && percent >= 2)
        {
            star1.sprite = fullstar;
            star2.sprite = fullstar;
            star3.sprite = emptystar;
            star4.sprite = emptystar;
        }
        else if (percent <= 3 && percent >= 1)
        {
            star1.sprite = fullstar;
            star2.sprite = emptystar;
            star3.sprite = emptystar;
            star4.sprite = emptystar;
        }
        else
        {
            star1.sprite = emptystar;
            star2.sprite = emptystar;
            star3.sprite = emptystar;
            star4.sprite = emptystar;
        }
    }


    private float setpercent()
    {
        if (questions.Achievements_Index == 0)
        {
            return (CountTrues(questions.Categoriy1First, questions.Categoriy1Last)/questions.Categoriy1Last)*4;
        }
        return 0;
    }


    private int CountTrues(int first, int last)
    {
        int trues = 0;
        for (int i = first; i < last; i++)
        {
            if (questions.TrueOnes[i] == true) trues++;
        }
        return trues;
    }


}
