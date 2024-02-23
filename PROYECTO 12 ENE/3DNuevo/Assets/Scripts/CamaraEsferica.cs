using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraEsferica : MonoBehaviour
{

    public float velocidadRotacion = 1;
    public Transform pivote;
    
    // Update is called once per frame
    void Update()
    {

        float rotMouseX = Input.GetAxis("Mouse X");
        pivote.Rotate(Vector3.up * rotMouseX);

        float rotMouseY = Input.GetAxis("Mouse Y");

        this.transform.Rotate(Vector3.right * rotMouseY, Space.World);
    }
}
