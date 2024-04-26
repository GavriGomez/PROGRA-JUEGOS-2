using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoSimple : MonoBehaviour
{
    private Rigidbody miCuerpo;
    private Animator miAnimador;

    public float velCaminar = 10;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movVertical = Input.GetAxis("Vertical");
        float movHorizontal = Input.GetAxis("Horizontal");

        if (movVertical > 0)
        {
            miCuerpo.velocity = new Vector3(0, 0, velCaminar);
            miAnimador.SetBool("CORRIENDO", true);
        }
        else if (movVertical < 0)
        {
            miCuerpo.velocity = new Vector3(0, 0, -velCaminar);
            miAnimador.SetBool("CORRIENDO", true);
        }
        else if (movHorizontal > 0)
        {
            miCuerpo.velocity = new Vector3(velCaminar, 0, 0);
            miAnimador.SetBool("CORRIENDO", true);
        }
        else if (movHorizontal < 0)
        {
            miCuerpo.velocity = new Vector3(-velCaminar, 0, 0);
            miAnimador.SetBool("CORRIENDO", true);
        }
        else
        {
            miCuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("CORRIENDO", false);
        }
    }
}