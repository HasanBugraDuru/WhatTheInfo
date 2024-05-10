using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class GiftAchimentButton : MonoBehaviour
{
    [SerializeField] AchievementData achievement;
    [SerializeField] private GameObject panel;
    [SerializeField] private int achievementno;
    [SerializeField] private TextMeshProUGUI InfoText;
    public void OpenGift()
    {
        panel.SetActive(true);
        achievement.AchievementNo = achievementno;
        FillAchievements();
         
    }
    public void CloseGift()
    {
        panel?.SetActive(false);
        
    }
    private void FillAchievements()
    {
        
       InfoText.text = achievement.AchievementInfo[achievement.AchievementNo];
    }
}
