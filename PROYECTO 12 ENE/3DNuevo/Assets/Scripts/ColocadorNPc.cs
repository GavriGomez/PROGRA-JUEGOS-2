using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[ExecuteInEditMode]
public class ColocadorNPc : MonoBehaviour
{
    private GameObject[] puntosSpawn;
    private int indicePunto = 0;
    private void Awake()
    {

        //el metodo awake se ejecuta antes del start e incluso lo hace sin dar play
        puntosSpawn = GameObject.FindGameObjectsWithTag("Puntos Spawn");
    }

    private void OnDrawGizmos()
    {
        if (puntosSpawn == null) ;
        {

            //aun no se inicializan el arreglo de puntos
            return;

        }

        foreach (GameObject punto in puntosSpawn)

        {

            Gizmos.DrawIcon(punto.transform.position, "Puntos Spawn");
        }

    }

    public void AlCrearNPC (GameObject generador, GameObject npc)
    {
        print("Se genero npc" + npc.name);

        //Obtenemos el siguiente punto del spawn
        GameObject punto = puntosSpawn [indicePunto];
        //Colocaos el npc en ese puunto

        npc.transform.position = punto.transform.position;

        //incremenetamos el indice del punto 

        indicePunto = (indicePunto + 1) % puntosSpawn.Length;

    }


}


