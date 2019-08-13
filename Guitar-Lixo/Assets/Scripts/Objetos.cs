using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    public float velocidade = 0.07f;

    void Update()
    {
        transform.Translate(Vector3.down * velocidade);
    }
}
