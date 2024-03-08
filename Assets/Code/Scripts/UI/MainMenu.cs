using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Para cambiar de escenas

public class MainMenu : MonoBehaviour
{
    //Variables para saber la escena a la que queremos ir, al princi
    public string startScene, startContinium;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Método para el Botón Start
    public void StartGame()
    {
        //Para saltar a la escena que le pasamos en la variable
        SceneManager.LoadScene(startScene);
    }

    //Método para el Botón Quit
    public void QuitGame()
    {
        //Para quitar el juego (solo funciona en la Build no en el editor)
        Application.Quit();
        //Feedback para el editor
        Debug.Log("Quitting Game");
    }

}
