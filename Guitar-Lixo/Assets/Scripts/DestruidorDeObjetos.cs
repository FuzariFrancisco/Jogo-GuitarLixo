using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruidorDeObjetos : MonoBehaviour
{
    public GameController controlador;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject)
        {
            Destroy(collision.gameObject);
            controlador.Errou();
        }
    }
}
