using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    public void TelaInicio()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void TelaGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Sair()
    {
        Application.Quit();
    }

}
