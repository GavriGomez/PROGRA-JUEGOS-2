using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private GameObject camara;

    [Header("Estadisticas Normales")]
    [SerializeField] private float velocidad;
    [SerializeField] private float alturaSalto;
    [SerializeField] private float tiempoGirar;

    [Header("Datos sobre el piso")]
    [SerializeField] private Transform detectarPiso;
    [SerializeField] private float distanciaPiso;
    [SerializeField] private LayerMask mascaraPiso;

    float velocidadGiro;
    float gravedad = 9.81f;
    Vector3 velocity;
    bool tocarPiso;


    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        camara = GameObject.FindGameObjectWithTag("MainCamara");

    }

    // Update is called once per frame
    private void Update()
    {
        tocarPiso = Physics.CheckSphere(detectarPiso.position, distanciaPiso, mascaraPiso);
        if (tocarPiso && velocity.y <0 )
        {
            velocity.y = -2f;
        }

        if(Input.GetButtonDown ("jump")&& tocarPiso )
        {
            velocity.y += gravedad * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
