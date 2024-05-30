using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    [SerializeField] private PlayerDatas playerDatas;
    [SerializeField] private Sprite MusicOn, MusicOff;
    private Image image;
    [SerializeField] private AudioSource music;
    private void Start()
    {
       image = GetComponent<Image>();
    }
    public void Music()
    {
        ControlMusic();
    }
    public void ControlMusic()
    {
        if (playerDatas.MusicOn)
        {
            image.sprite = MusicOff;
            playerDatas.MusicOn = false;
            music.Pause();
        }
        else
        {
            image.sprite = MusicOn;
            playerDatas.MusicOn = true;
            music.UnPause();
        }

    }
}
