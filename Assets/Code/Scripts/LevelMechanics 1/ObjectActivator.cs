using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivator : MonoBehaviour
{
     //Variable para conocer el estado del objeto
    public bool isActive = false;
    //En este caso este m�todo activa el objeto
    public void ActivateObjet()
    {
        GetComponent<Animator>().SetTrigger("Activate");
    }
    //En este caso este m�todo desactiva el objeto
    public void DeactivateObjet()
    {
        GetComponent<Animator>().SetTrigger("Deactivate");
    }
}
