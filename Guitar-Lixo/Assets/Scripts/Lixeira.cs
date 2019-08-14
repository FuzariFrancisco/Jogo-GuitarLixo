using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixeira : MonoBehaviour
{
    Animator animacao;
    public KeyCode key;
    float posY;
    float posX;

    void Start()
    {
        animacao = GetComponent<Animator>();
        posX = transform.position.x;
        posY = transform.position.y;
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

        if (animacao.GetBool("Braco"))
        {
            transform.position = new Vector2(posX, posY * 0.03f);
        }
        else
        {
            transform.position = new Vector2(posX, posY);
        }
    }
}
