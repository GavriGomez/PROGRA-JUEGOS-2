using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaInteractiva : ObjetoInteractuable
{
    public Light laLuz;

   public override void Activar()
    {
        if (laLuz.gameObject.activeInHierarchy)
        { //ya esta encendida
            laLuz.gameObject.SetActive(false);
            nombreAccion = "Encender Luz";
        }
        else
        {
            laLuz.gameObject.SetActive(true);
            nombreAccion = "Apagar Luz";
        }
    }
}