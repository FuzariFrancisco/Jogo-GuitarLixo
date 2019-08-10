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

    public GameObject Metal;
    public GameObject Papel;
    public GameObject Plastico;
    public GameObject Vidro;

    void Update()
    {
        if (Input.GetKeyDown(keyMetal) && activeMetal)
        {
            Destroy(Metal);
        }

        if (Input.GetKeyDown(keyPapel) && activePapel)
        {
            Destroy(Papel);
        }

        if (Input.GetKeyDown(keyPlastico) && activePlastico)
        {
            Destroy(Plastico);
        }

        if (Input.GetKeyDown(keyVidro) && activeVidro)
        {
            Destroy(Vidro);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Metal)
        {
            activeMetal = true;
            Metal = collision.gameObject;
        }

        if (collision.gameObject == Papel)
        {
            activePapel = true;
            Papel = collision.gameObject;
        }

        if (collision.gameObject == Plastico)
        {
            activePlastico = true;
            Plastico = collision.gameObject;
        }

        if (collision.gameObject == Vidro)
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
