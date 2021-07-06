using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;

public class ScriptCuestion : MonoBehaviour
{
	public static ScriptCuestion inst; //Para hacerlo un Singletone

    public Button CuestionarioFin;
    public Button Historial;
    public static string variable;
    public static string variable1;

    public string nombre = "";
    public string boleta = "";

    public string Nombreprefs="Nombre";
    public string boletaprefs="Boleta";

    public static ValidarCampos inst1;

    void Awake() 
    {
    	if(ScriptCuestion.inst == null){
    		//Significa que es la primera vez que ocurre esto
    		ScriptCuestion.inst = this;
    		DontDestroyOnLoad (gameObject);
    		Load();
    		CuestionarioFin.interactable = false;
    		Historial.interactable = false;
    	}else{
    		//Ya hay una instancia, eliminar en ese caso
    		Destroy(gameObject);
    	}

    }

    void Start(){
    	CuestionarioFin = GameObject.FindWithTag("CFinal").GetComponent<Button>();
    	Historial = GameObject.FindWithTag("Historial").GetComponent<Button>();
    }

    public static void habilitarFinal(){
    	inst.CuestionarioFin.interactable = true;
       	inst.Historial.interactable = true;
    }

    private void Nombrecito(){
    	ValidarCampos.inst1.nombre = variable;
    }

    private void Load(){
    	variable = PlayerPrefs.GetString(Nombreprefs,nombre);
    	variable1 = PlayerPrefs.GetString(boletaprefs,boleta);
    }
}
