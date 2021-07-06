using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCadena : MonoBehaviour
{
    public Transform Camara;
    public float velocidad;
    Rigidbody Jugador;

    void Start()
    {
    	Jugador = GetComponent<Rigidbody>();
        
    }
    void FixedUpdate(){
    	Jugador.velocity = Camara.forward * velocidad * Time.deltaTime;
    }
}