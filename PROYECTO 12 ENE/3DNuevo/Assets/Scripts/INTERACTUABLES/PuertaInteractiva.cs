using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractiva : ObjetoInteractivo
 
{
    public float rotacionAbierto = 0;
    public float rotacionCerrado = 0;

    private bool estaAbierta = false;
    public override void Activar()
    {
        //esta es la accion que se ejecuta cuando se interactua con una puerta
        if (estaAbierta)
            //Ya esta abierta, la cierro
        {
            transform.rotation = Quaternion.Euler(0, rotacionCerrado, 0);
            nombreAccion ="Abrir puerta";

        }
        else
        {
            //No esta abierta, se abre
            transform.rotation=Quaternion.Euler(0, rotacionAbierto, 0);
            nombreAccion = "Cerrar puerta";

        }
        //Invierto el valor boleano
        estaAbierta = !estaAbierta;
    }
    
}
