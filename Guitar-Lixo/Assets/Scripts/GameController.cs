using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text tempo;
    public Text pontos;

    public float timer = 60;

    bool isRunning = true;

    public static int pontosGame = 0;

    void Start()
    {
        tempo.text = "Tempo: 00:00";
        pontos.text = "Pontos: 0";
    }

    void Update()
    {
        pontos.text = "Pontos: " + pontosGame.ToString();
        if (isRunning)
        {
            timer -= Time.deltaTime;
            tempo.text = "Tempo: " + Mathf.RoundToInt(timer).ToString() + " s";

            if (timer <= 0){
                isRunning = false;
            }
        }
    }

    public void Pontuou(){
        pontosGame++;
    }

    public void Errou(){

    }
}
