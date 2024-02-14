using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorUI : MonoBehaviour
    //Manejo una instancia estatica del controlador UI
    //como si fuera un sinlgeton, para facilitar su acceso desde otras clases

{
    public static ControladorUI Instancia; 

    public GameObject grupoPromptInteraccion;
    public TextMeshProGUI textoPrompt;

    private void Start()
    {
        Instancia = this; 
    }

    public void MostrarInteractuable (ObjetoInteractuable obj)
    {
        //este metodo se invoca por cualquier otro script del juego para que se muestre en el
        //UI el prompt de un objeto interactuable
        if (obj != null)
        {
            //Muestro el grupo de interaccion de UI
            grupoPromptInteraccion.SetActive(true);  //el nombre de accion del objeto es lo que se muestra en el texto del prompt
            textoPrompt.text = obj.nombreAccion;
        }
        else
        {
            grupoPromptInteraccion.SetActive(false);
        }
    }
}