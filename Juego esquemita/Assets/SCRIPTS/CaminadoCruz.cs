using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoCruz : MonoBehaviour
{
    private Rigidbody miCuerpo;
    private Animator miAnimador;

    public float velCaminar = 5;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movFrontal = Input.GetAxis("Vertical");
        float movLateral = Input.GetAxis("Horizontal");

        miAnimador.SetFloat("MOV_FRONTAL", movFrontal);
        miAnimador.SetFloat("MOV_LATERAL", movLateral);

        miCuerpo.velocity = (transform.forward * movFrontal + transform.right * movLateral) * velCaminar;
    }
}