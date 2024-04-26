using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float salto;

    public Transform detectarPiso;
    public float distanciaPiso;
    public LayerMask mascaraPiso; //el personaje solo salta si esta en el piso

    private float gravedad = -9.01f;

    bool tocaPiso;
    Vector3 velocidad;
    CharacterController controller;
    Animator miAnimador;

    private void Start()
    {
        miAnimador = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        tocaPiso = Physics.CheckSphere(detectarPiso.position, distanciaPiso, mascaraPiso);

        if (!tocaPiso)
        {
            miAnimador.SetBool("salto,true");
        }

        else
        {
            miAnimador.SetBool("salto, false");
        }
        if (Input.GetButtonDown("Jump") && tocaPiso)
         {
            velocidad.y = Mathf.Sqrt(salto * -2 * gravedad);
         }

        velocidad.y += gravedad * Time.deltaTime;
        controller.Move(velocidad * Time.deltaTime);
            
             
    }
}
