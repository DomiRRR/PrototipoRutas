using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class ValidarCampos : MonoBehaviour
{
	//public TextMeshPro nombre; //Guardar el texto 
	//public TMP_InputField InptUser; 

	public string nombre = "";
    public string boleta = "";

    public string Nombreprefs="Nombre";
    public string boletaprefs="Boleta";

    public TMP_InputField NombreIntroducido;
    public TMP_InputField BoletaIntroducido;

    public GameObject Panel;

    public Text Alerta;
    public TextMeshProUGUI Cambiotxtbtnregistrar;

    public static ValidarCampos inst1; //Para hacerlo un Singletone

    void Awake() 
    {
        if(ValidarCampos.inst1 == null){
            //Significa que es la primera vez que ocurre esto
            ValidarCampos.inst1 = this;
            DontDestroyOnLoad (gameObject);
            LoadData();
        }else{
            //Ya hay una instancia, eliminar en ese caso
            Destroy(gameObject);
        }

    }

	 void Start()
    {
 		TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
    }

public void Validar() 
{
	//nombre.text = InptUser.text; Esto obtiene el teexto del nombre y lo pone en un input
		nombre = NombreIntroducido.text;
        boleta = BoletaIntroducido.text;

        if (nombre != "" && boleta != "") //O sea que nombre y boleta tienen datos pos se guarda
        {
        	Panel.SetActive(true);
        	Alerta.text = ("Registro guardado con éxito.");
            GuardarDatos();
        }

        if (nombre!= "" && boleta == "")// Nombre contiene datos y boleta es un campo vacio
        {
        	Panel.SetActive(true);
        	Alerta.text = ("Registro guardado con éxito.");
        	GuardarDatos();
        }

        if(nombre==""){
        	Panel.SetActive(true); //Aqui aparecere un cuadro WARNING en el que le advierte al usuario que no debe dejar este campo vacío
            NombreIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            BoletaIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            Alerta.text = ("Error al guardar:" + "\n" + 
            	           "Porfavor introduzca su nombre completo");
        }
        if(nombre=="" && boleta ==""){
        	Panel.SetActive(true); //Aqui aparecere un cuadro WARNING en el que le advierte al usuario que no debe dejar este campo vacío
            NombreIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            BoletaIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            Alerta.text = ("Error al guardar:" + "\n" + 
            	           "Porfavor introduzca su nombre completo");
        }

        //PENDIENTE ARREGLAR
       /*else{ //Este no me funciona ya que 'string' does not contain a definition for 'length' and no accessible extension method 'length' 
        		for(int i=0; i<str1.Length; i++)
 				{
      				if (numeros.indexOf(nombre.charAt(i),0)>=1) //contiene numeros
      				{
        		 	 Panel.SetActive(true); //Aqui aparecere un cuadro WARNING en el que le advierte al usuario que no debe dejar este campo vacío
           		 	 NombreIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            	  	 BoletaIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            	  	 Alerta.text = ("Error al guardar: El nombre no puede contener números" + "\n" + 
            	  	 				"o caracteres especiales");
      				}
      			}
      		}
      	*/

}

public void GuardarDatos()
    {
        if (PlayerPrefs.HasKey(Nombreprefs))
        {
            Panel.SetActive(true);
            Alerta.text = ("Error al guardar: Este alumno ya existe");
            MandaraEscenaCuestionarios();
         }
        else{
            PlayerPrefs.SetString(Nombreprefs,nombre);
            PlayerPrefs.SetString(boletaprefs,boleta);

            Panel.SetActive(true);
            NombreIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            BoletaIntroducido.enabled = false; //No permite al usuario escribir en los campos hasta cerrar el POP-UP
            Alerta.text = ("Registro exitoso");
            Cambiotxtbtnregistrar.text = ("Continuar");
        }
}

public void LoadData(){
    nombre = PlayerPrefs.GetString(Nombreprefs,null);
    boleta = PlayerPrefs.GetString(boletaprefs,null);
}

private void OnDestroy()
{
    GuardarDatos();
}

public void CerrarCuadroDialogo(){
	Panel.SetActive(false); //Desaparece el POP-UP
	NombreIntroducido.enabled = true; //Permite que el usuario escriba de nuevo en los campos
 	BoletaIntroducido.enabled = true;
}

//Esto podria mejorar ya que al dar en el botón de registrar no hay otro botón que diga que el usuario exista
//y lo mande direactamente a la pantalla de cuestionarios

public void MandaraEscenaCuestionarios(){ 
         SceneManager.LoadScene("CPrincipal");

}

}

