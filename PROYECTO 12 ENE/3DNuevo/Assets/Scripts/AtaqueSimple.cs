using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueSimple : MonoBehaviour
{

    private Animator miAnimador;
    
    void Start()
    {
        miAnimador  = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("fire1"))
        {
            miAnimador.SetTrigger("ATACAR");
        }
    }
}
