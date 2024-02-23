using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public PlayerHealthController _pHReference;

    private void Start()
    {
        _pHReference = GameObject.Find("Player").GetComponent<PlayerHealthController>();
    }
    //Método que detecta cuando el jugador se mete dentro de un trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Comprobamos si es el jugador el que ha entrado en la zona de trigger
        if (collision.CompareTag("Player"))
        {
            
        }
    }




}

