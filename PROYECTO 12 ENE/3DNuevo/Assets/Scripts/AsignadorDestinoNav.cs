using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class AsignadorDestinoNav : MonoBehaviour
  
{
    public GameObject destino;
    private NavMeshAgent navegadorIA;
    void Start()
    {
        navegadorIA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (destino ! = null )
        {
            navegadorIA.destination = destination.transform.position;
        }
    }
}
