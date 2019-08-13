using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alvo : MonoBehaviour
{
    public KeyCode keyMetal;
    public KeyCode keyPapel;
    public KeyCode keyPlastico;
    public KeyCode keyVidro;

    bool activeMetal = false;
    bool activePapel = false;
    bool activePlastico = false;
    bool activeVidro = false;

    GameObject Metal;
    GameObject Papel;
    GameObject Plastico;
    GameObject Vidro;

    public GameController controlador;

    void Update()
    {
        if (Input.GetKeyDown(keyMetal) && activeMetal)
        {
            Destroy(Metal);
            controlador.Pontuou();
        }

        if (Input.GetKeyDown(keyPapel) && activePapel)
        {
            Destroy(Papel);
            controlador.Pontuou();
        }

        if (Input.GetKeyDown(keyPlastico) && activePlastico)
        {
            Destroy(Plastico);
            controlador.Pontuou();
        }

        if (Input.GetKeyDown(keyVidro) && activeVidro)
        {
            Destroy(Vidro);
            controlador.Pontuou();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Metal")
        {
            activeMetal = true;
            Metal = collision.gameObject;
        }

        if (collision.gameObject.tag == "Papel")
        {
            activePapel = true;
            Papel = collision.gameObject;
        }

        if (collision.gameObject.tag == "Plastico")
        {
            activePlastico = true;
            Plastico = collision.gameObject;
        }

        if (collision.gameObject.tag == "Vidro")
        {
            activeVidro = true;
            Vidro = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        activeMetal = false;
        activePapel = false;
        activePlastico = false;
        activeVidro = false;
    }

}
