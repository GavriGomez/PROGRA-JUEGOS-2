using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraIsométrica : MonoBehaviour
{
    //MOVIMIENTO
    public float velocidadMovimiento = 5f;
    public float umbralCamara = .005f;

    void Update()
    {
        //Velocidad del movimiento
        Vector3 velocidad = new Vector3();

        //Condicional para cambio de posicion

        if (Input.mousePosition.x < Screen.width * umbralCamara)
        {
            velocidad.x -= velocidadMovimiento;
        }
        else if (Input.mousePosition.x > Screen.width - (Screen.width * umbralCamara))
        {
            velocidad.x += velocidadMovimiento;
        }

        if (Input.mousePosition.y < Screen.height * umbralCamara)
        {
            velocidad.z -= velocidadMovimiento;
        }
        else if (Input.mousePosition.y > Screen.height - (Screen.height * umbralCamara))
        {
            velocidad.z += velocidadMovimiento;
        }

        transform.position += velocidad * Time.deltaTime;
    }
}