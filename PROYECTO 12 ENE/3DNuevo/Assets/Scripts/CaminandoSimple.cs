using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminandoSimple : MonoBehaviour
{
    private Animator miAnimador;
    private Rigidbody miCuerpo;
    public float velCaminando = 10;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
        miCuerpo = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float despx = Input.GetAxis("Vertical");
        miCuerpo.velocity = transform.forward * despx * velCaminando;

        miAnimador.SetBool("CAMINANDO", despx != 0);
    }
}
