/*
 * Chandler Wesoloski
 * MainMenu.cs
 * Project 2
 * Contatins the logic for the main menu
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
