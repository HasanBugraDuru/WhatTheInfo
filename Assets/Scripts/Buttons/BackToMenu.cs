using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Open_Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
