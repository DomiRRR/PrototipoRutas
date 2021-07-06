using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAutoCam : MonoBehaviour
{
    public Transform Camara;
    public float velocidad;
    Rigidbody Jugador;

    void Start()
    {
    	Jugador = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
    	Jugador.velocity = Camara.forward * velocidad * Time.deltaTime;
    }
}
