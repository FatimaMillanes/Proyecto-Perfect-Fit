using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class SeguirPersonaje : MonoBehaviour
{
    public NavMeshAgent enemigo;
    public Transform personaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemigo.SetDestination(personaje.position);
    }
}
