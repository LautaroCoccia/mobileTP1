using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button FirstButton;

    public void Start()
    {
        FirstButton.Select();
    }
    public void Singleplayer()
    {
        
    }
    public void Multiplayer()
    {
        SceneManager.LoadScene("conduccion9");
    }
    public void Settings()
    {
        
    }
    public void Credits()
    {
        
    }
    public void Quit()
    {
        Application.Quit();
    }
}
