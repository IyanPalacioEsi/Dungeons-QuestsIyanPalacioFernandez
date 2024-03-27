using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
     //Objeto sobre el que act�a el interruptor
    public GameObject objetToSwitch;
    //Sprites al cambiar de estado el interruptor
    public Sprite downSprite, upSprite;
    //Desactivamos al usar el interruptor
    private bool _activateSwitch;
    //Referencia al panel de informaci�n
    public GameObject infoPanel;
    //Referencia al SpriteRenderer del interruptor
    private SpriteRenderer _sR;
    //Referencia al PlayerController
    private PlayerController _pC;
    public bool canInteract;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos la referencia al SpriteRenderer
        _sR = GetComponent<SpriteRenderer>();
        //Inicializamos la referencia al PlayerController
        _pC = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos el bot�n E y el jugador puede interactuar
        if (Input.GetKeyDown(KeyCode.E) && _pC.canInteract)
        {
            //Si el objeto est� desactivado
            if(objetToSwitch.GetComponent<ObjectActivator>().isActive == false)
            {
                //Hacemos en este caso la animaci�n del objeto sobre el que queremos que interact�e
                objetToSwitch.GetComponent<ObjectActivator>().ActivateObjet();
                //Activamos el objeto
                objetToSwitch.GetComponent<ObjectActivator>().isActive = true;
            }

            //Si el objeto si estaba activado
            else
            {
                //Hacemos en este caso la animaci�n del objeto sobre el que queremos que interact�e
                objetToSwitch.GetComponent<ObjectActivator>().DeactivateObjet();
                //Desactivamos el objeto
                objetToSwitch.GetComponent<ObjectActivator>().isActive = false;
            }
                
        }
    }

    //M�todo para conocer cuando un objeto entra en la zona de Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si el jugador es el que entra en la zona del interruptor
        if (collision.CompareTag("Player"))
        {
            //Mostramos el panel de informaci�n
            infoPanel.SetActive(true);
            //Permitimos al jugador que pueda interactuar con el objeto
            collision.GetComponent<PlayerController>().canInteract = true;
        }
    }

    //M�todo para conocer cuando un objeto sale de la zona del interruptor
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Si el que sale es el jugador
        if (collision.CompareTag("Player"))
        {
            //Ocultamos el panel de informaci�n
            infoPanel.SetActive(false);
            //No permitimos al jugador que pueda interactuar con el objeto
            collision.GetComponent<PlayerController>().canInteract = false;
        }
    }
}
