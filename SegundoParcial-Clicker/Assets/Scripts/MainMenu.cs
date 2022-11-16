using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("GAME");
    }

    public void Salir()
    {
        Application.Quit();

    }

    public void EscenaMainMenu()
    {
        SceneManager.LoadScene("MENU");

    }

    public void EscenaInfoS()
    {
        SceneManager.LoadScene("INFO");
    }
}
