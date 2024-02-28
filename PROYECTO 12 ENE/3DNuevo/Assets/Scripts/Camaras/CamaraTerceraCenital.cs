using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraCenital : MonoBehaviour
{
    public Transform Heroe;
    public float altura = 10f;

    void Update()
    {
        //condiconal
        if (Heroe == null)
        {
            return;
        }

        //posicion de la camara
        transform.position = new Vector3(Heroe.position.x, altura, Heroe.position.z-5);
        transform.LookAt(Heroe.position);
    }
}