using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTerceraEsferica : MonoBehaviour
{
    public Transform pivote;
    public float velRotacion = 3f;
    public float limiteRotY = 140f;

    private float rotacionVer = 0f;

    void Update()
    {
        float movHor = Input.GetAxis("Mouse X") * velRotacion;
        float movVer = Input.GetAxis("Mouse Y") * velRotacion;

        pivote.Rotate(Vector3.up * movHor, Space.Self);

        rotacionVer += movVer;
        rotacionVer = Mathf.Clamp(rotacionVer, -limiteRotY, limiteRotY);
        pivote.localEulerAngles = new Vector3(-rotacionVer, pivote.localEulerAngles.y, 0f);
    }
}