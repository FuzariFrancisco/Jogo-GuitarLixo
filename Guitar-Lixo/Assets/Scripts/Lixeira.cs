using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixeira : MonoBehaviour
{
    Animator animacao;
    public KeyCode key;

    void Start()
    {
        animacao = GetComponent<Animator>();
    }
    
    void Update()
    {
        if(Input.GetKey(key))
        {
            animacao.SetBool("Braco", true);
        }
        else
        {
            animacao.SetBool("Braco", false);
        }
    }
}
