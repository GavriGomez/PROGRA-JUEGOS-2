using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionporLados : MonoBehaviour
{
    public float velocidadRotacion=1;

    void Start()
    {
        
    }

    void Update()
    {
        //leer el valor de desplazamiento del eje 
        float rotHorizontal =Input.GetAxis("Mouse X");//leer el eje secundario

        //Roto el objeto sobre su eje en relacion a si mismo, no al mundo
        transform.Rotate(transform.up * rotHorizontal. Space.Self);


    }
}
