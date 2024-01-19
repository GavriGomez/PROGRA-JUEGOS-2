using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminandoDireccional : MonoBehaviour

   
    
{
    //Declarar un atributo flotante para la velocidad :3
    public float velocidadDireccion = 1;

    private Rigidbody Cuerpo;
    private Animator Animador;
    void Start()
    {
        Cuerpo = GetComponent<Rigidbody>();
        Animador = GetComponent<Animator>();
    }

    void Update()
    {
        //leo los valores de los ejes horizontal y vertical de input y guardo cada uno en una variable :3
        float movFrontal = Input.GetAxis("Vertical");
        float movLateral = Input.GetAxis("Horizontal");

        //crear una nueva instancia del Vector3 utilizando los valores de los ejes en y, x y z
        Vector3 direction = new Vector3(movFrontal,0,movLateral);

        //Asignar ese nuevo vector a la propiedad forward del transform
        transform.forward = direction ;

        //Modificar para que use Lerp en vez de asignar directamente

        //Asignar velocidad al RB multiplicando el vector forward por la velocidad por la magnitud del vector nuevo de direccion
        Cuerpo.velocity = transform.forward * velocidadDireccion *direction. magnitude  ;

        //Al animator le activamos el boleano de caminando, si la magnitud del vector 
        Animador.SetBool("CAMINANDO", direction .magnitude <0);


    }
      
      
}
