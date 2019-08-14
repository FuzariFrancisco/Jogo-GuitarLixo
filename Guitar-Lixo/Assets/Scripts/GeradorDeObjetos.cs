using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObjetos : MonoBehaviour
{
    public GameObject Metal;
    public GameObject Plastico;
    public GameObject Vidro;
    public GameObject Papel;
    public float countdown = 3.5f;

    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0.0f)
        {
            int random = Random.Range(1, 5);
            if(random == 1){
            Instantiate(Metal, new Vector3(0, 14f, 0), Quaternion.identity);
            }else if(random == 2){
                Instantiate(Plastico, new Vector3(0, 14f, 0), Quaternion.identity);
            }else if(random == 3){
                Instantiate(Vidro, new Vector3(0, 14f, 0), Quaternion.identity);
            }else if(random == 4){
                Instantiate(Papel, new Vector3(0, 14f, 0), Quaternion.identity);
            }
            countdown = 5.0f;
        }

        
    }
}
