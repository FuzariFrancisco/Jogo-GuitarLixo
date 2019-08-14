using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text tempo;
    public Text pontos;
    public Text final;
    public GameObject panel;
    public AudioSource erro;
    public AudioSource ponto;

    public float timer = 60;

    bool isRunning = true;

    public static int pontosGame = 0;

    void Start()
    {
        tempo.text = "TEMPO: 00:00";
        pontos.text = "PONTOS: 0";
        timer = 60;
        pontosGame = 0;
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        pontos.text = "PONTOS: " + (pontosGame * 10).ToString();
        if (isRunning)
        {
            timer -= Time.deltaTime;
            tempo.text = "TEMPO: " + Mathf.RoundToInt(timer).ToString() + " S";

            if (timer <= 0){
                isRunning = false;
                Time.timeScale = 0;
                panel.SetActive(true);
                final.text = "SUA PONTUAÇÃO FINAL FOI: " + (pontosGame * 10).ToString();
            }
        }
    }

    public void Pontuou(){
        pontosGame++;
        ponto.Play();
    }

    public void Errou(){
        erro.Play();
    }


}
