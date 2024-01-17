
public class CaminandoCruz : MonoBehaviour
{
    //DECLARAR UN ATRIBUTO FLOTANTE PARA LA VELOCIDAD
    //Obtenemos los componentes del rb y el animator para guardarlos en los atributos
    private Rigidbody Cuerpo;
    private Animator Animador;
    public float  velocidadCaminar;


    void Start()
    {
        Cuerpo = GetComponent<Rigidbody>();
        Animador = GetComponent<Animator>();
    }

    void Update()
    {
         //leo los valores de los ejes horizontal y vertical de input y guardo cada uno en una variable
        float movFrontal= Input.GetAxis("Vertical");
        float movLateral = Input.GetAxis("Horizontal");  

      
        //mando el valor de cada eje a los pares correspondientes del animator
        Animador.SetFloat("MOVLATERAL",movFrontal);
        Animador.SetFloat("MOVFRONTAL",movLateral);
         //ASIGNAR VELOCIDAD AL RB MULTIPLICANDO EL FORWARD DEL PERSONAJE X EL MOVFRONTAL Y SUMANDO EL RIGHT MULTIPLICADO POR EL MOVIMIENTO LATERAL
       Cuerpo.velocity = ( transform.forward * movFrontal + transform.right * movLateral)*velocidadCaminar;

      
        
        

        //FIN
    }
}
