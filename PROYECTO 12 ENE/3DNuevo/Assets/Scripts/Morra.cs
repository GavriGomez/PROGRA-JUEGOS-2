using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morra : MonoBehaviour

{//Obtenemos los componentes del rb y el animator para guardarlos en los atributos
    private Rigidbody Cuerpo;
    private Animator Animador;
    public float  velocidadCaminar;
    void Start()
    {  //Obtener componentes del Start.todo lo que esta en rigidbody lo obtiene, asi como animator 
        Cuerpo = GetComponent<Rigidbody>();
        Animador = GetComponent<Animator>();
       
    } // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");  
        
        //Verificar si el input vertical y  el horizontal es mayor a 0

        if (movHorizontal != 0|| movVertical != 0)
        {
            //Definir velocidad
           Vector3 direction =(transform.forward * movVertical+transform.right * movHorizontal ).normalized;
           Cuerpo.velocity = direction * velocidadCaminar;
            //Activar boleano de caminar en el animator
            Animador.SetBool("CAMINANDO", true);
        }
        else
        {
            Cuerpo.velocity = new Vector3(0, 0, 0);
            Animador.SetBool("CAMINANDO", false);
        }
    }
}
