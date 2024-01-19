using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionporMouse : MonoBehaviour
{
    public float velocidadRot = 5;
    void Update()
    {
        float rotHoriz = Input.GetAxis("Mouse X");
        transform.Rotate(transform.up * rotHoriz * velocidadRot, Space.Self);
    }
}
