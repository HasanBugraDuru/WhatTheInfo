using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDatas", menuName = "Player Datas")]
public class PlayerDatas :  ScriptableObject
{
    [Header("Config")]
    [SerializeField] public bool MusicOn;
    [SerializeField] public int PlayTime;
 }
