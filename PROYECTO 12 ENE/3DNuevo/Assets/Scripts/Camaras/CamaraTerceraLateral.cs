using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraLateral : MonoBehaviour
{
    
    public Transform Heroe;
    public float velSeg = 5f;
    public Vector3 posCamara = new Vector3(-5f, 2f, 0f);
   

    void Update()
    {
        if (Heroe == null)
        {
            return;
        }

        //posicion del perso
        Vector3 posicionHeroe = Heroe.position + posCamara;

        transform.position = Vector3.Lerp(transform.position, posicionHeroe, velSeg * Time.deltaTime);

        transform.LookAt(Heroe.position);
    }
}
