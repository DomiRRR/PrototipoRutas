using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RespuestasScriptFinal : MonoBehaviour
{
	public bool isCorrect = false;
	public ManejoCuestionarioFinal quizmanager;

    private void Start()
    {

    }

    public void Answer(){
    	if(isCorrect){
    		Debug.Log("Respuesta Correcta");
    		quizmanager.correct();
    	}
    	else{
    		Debug.Log("Respuesta incorrecta");
    		quizmanager.wrong();
    	}

    }
}
