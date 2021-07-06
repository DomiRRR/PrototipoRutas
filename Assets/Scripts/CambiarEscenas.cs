using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; //Para las escenas
using UnityEngine;


public class CambiarEscenas : MonoBehaviour
{

	public void Botones(string escenas) {

     switch (escenas) {
         case "Mapas": //Escenario MAPA GENERAL PENDIENTE incluir el mapa general de las rutas... el modelado
             	SceneManager.LoadScene(escenas);
             break;
         case "MenuSecu": //Escenario MENÚ SECUNDARIO
             	SceneManager.LoadScene(escenas);
             break;
         case "Cuestionarios": //Escenario REGISTRO P CUESTIONARIO
         		SceneManager.LoadScene(escenas);
         	break;
         case "MenuPri": //Escenario MENÚ PRINCIPAL | Volver
         		SceneManager.LoadScene(escenas);
         	break;
         case "GlucolisisInterfaz": //Cargar las interfaces, interfaz Glucólisis
         		SceneManager.LoadScene(escenas);
         	break;
         case "CicloKrebsInterfaz": //Cargar las interfaces, interfaz CicloKrebs
         		SceneManager.LoadScene(escenas);
         	break;
         case "CadenaTraInterfaz": //Cargar las interfaces, interfaz Cadena
         		SceneManager.LoadScene(escenas);
         	break;
         case "FosfoInterfaz": //Cargar las interfaces, interfaz Fosforilación
         		SceneManager.LoadScene(escenas);
         	break;
         case "Glucolisis2": //Escenario VIRTUAL GLUCÓLISIS
         		SceneManager.LoadScene(escenas);	
         	break;
        case "Krebs2": //Escenario VIRTUAL CICLO KREBS PENDIENTE DE CREAR
                SceneManager.LoadScene(escenas);    
            break;
        case "Cadena2": //Escenario VIRTUAL CADENA TRANSPORTES PENDIENTE DE CREAR
                SceneManager.LoadScene(escenas);    
            break;
        case "Fosfo2": //Escenario VIRTUAL FOSFORILACIÓN OXIDATIVA PENDIENTE DE CREAR
                SceneManager.LoadScene(escenas);    
            break;
        case "CIni": //CUESTIONARIO INICIAL (Crear estos escenarios)
                SceneManager.LoadScene(escenas);    
            break;
        case "CPrincipal":
                SceneManager.LoadScene(escenas);    
            break;
        case "CFinal": //CUESTIONARIO FINAL (Crear estos escenarios)
                SceneManager.LoadScene(escenas);    
            break;
        case "Historial": //CUESTIONARIO FINAL (Crear estos escenarios)
                SceneManager.LoadScene(escenas);    
            break;
        case "Salir":
             	Application.Quit();
            break;            
     }

}
  
}
