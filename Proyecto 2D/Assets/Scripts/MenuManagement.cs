using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    public void EscenaJuego()
    {
        SceneManager.LoadScene("JuegoPrincipal");
    }

    public void MenuTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }
}
