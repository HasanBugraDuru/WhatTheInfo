using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Achievement", menuName = "Achievements")]
public class AchievementData : ScriptableObject
{
    [SerializeField] public int AchievementNo;
    [SerializeField] public string[] AchievementInfo;
    [SerializeField] public Sprite AchievementImage;
}
