using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class Escenas3D : MonoBehaviour
{

//Script para cargar los eventos en el momento en que termina la animación del menú e inicia la del movimiento 3D
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    	public void reproducirVR(){
		 SceneManager.LoadScene("Glucolisis2");//IniciarRecorrido();
	}	
}
