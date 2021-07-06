using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

//Este script es para crear una carpeta que se llama Datos dentro del proyecto, se creara cuando sea seleccionado
//el botón de cuestionarios dentro del menú principal

public class CarpetaCues : MonoBehaviour
{
	 public string carpeta = "C:/Users/darky/Downloads/ProjectRutas/ProyectoRutas/Datos";

   public void Crear()
    {
    	if (Directory.Exists(carpeta))
        {
            Debug.Log("Error esta carpeta ya existe en la ruta asignada");

        }
        else
            Debug.Log("Creando carpeta...");
        Directory.CreateDirectory(carpeta);
        
    }
}
