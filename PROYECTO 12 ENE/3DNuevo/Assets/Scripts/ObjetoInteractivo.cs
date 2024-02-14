using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public abstract class ObjetoInteractivo : MonoBehaviour
{
    public string nombreAccion; //prompt
    //Este metodo es abstracto, es una promesa de la accion a realizar. Se defie en una clase que hereda esta

    public abstract void Activar();
    public bool enContacto = false;
    private void OnTriggerEnter(Collider other)

    void Start()
    {
        //condicionar a que el contacto sea con el Player
        //SSolicito al controlador de UI que nmuestre la info de prompt de este objeto interactuable

        ControladorUI.Instancia.MostrarInteractuable(this);
        enContacto == true; 
    }

    private void OnTriggerExit (Collider other)
    {
        //Solicito al controlador que deje de mostrar
        ControladorUI.Instancia.MostrarInteractuable(null);
        enContacto = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag !="Player")
        {
            //si no es el player, no sigo
            return;
        }
        //Condicionar a que el contacto sea con el player
    }
   private void Update()
   {
        if (Input.GetButtonDown("Fire1")&& enContacto)
        {
            //si se presiona el boton y esta en contacto, ejecuto la accion abstracta
            Activar();
        }
   }
}
