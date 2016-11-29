using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject settings;
    public GameObject menu;
    public string level;
    public void StartGame()
    {
        Application.LoadLevel(1);
    }
    public void LoadGame()
    {

    }
    public void Settings()
    {
        settings.SetActive(!settings.activeSelf);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Menu()
    {
        Application.LoadLevel(0);
    }
    public void NextLevel()
    {
        Application.LoadLevel(2);
    }
    public void Restart()
    {
        Application.LoadLevel(level);
       
    }
    public void Button()
    {
        menu.SetActive(!menu.activeSelf);
    }

    public void setMusic(float value)
    {
        Global.music = value;
    }

    public void setSound(float value)
    {
        Global.sound = value;
    }


}