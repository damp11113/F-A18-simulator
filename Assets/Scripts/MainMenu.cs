using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        Application.LoadLevel("Main");
    }
    public void SettingsGame() {
        Application.LoadLevel("Settings");
    }
    public void ExitGame() {
        Debug.Log("Exit!");
        Application.Quit();
    }
}
