using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement; //Para las escenas

public class ManejoCuestionarioFinal : MonoBehaviour
{
	public List<QAFinal> QA;
	public GameObject[] opciones;
	public int currentQuestion;

	public Text Preguntatxt;

	public GameObject PanelPreguntas; //Panel donde se encuentran las preguntas actuales
	public GameObject PanelRety; //Panel o POPUP que aparece después de perder

	public Text Scoretxt; //Puntaje
	public int score;

	public Text PreguntaActualTxt; //Despliega la pregunta actual
	public int numeroactual = 1;

	int totalQuestion = 0;

	public string createDirectory; 


	public static ScriptCuestion inst2;

	private void Start()
	{
		numeroactual = 1;
		totalQuestion = QA.Count;
		PanelRety.SetActive(false);
		createDirectory = Application.persistentDataPath + "/ResultadosCuestionarioFinal";
		GenerarPregunta();
	}

	public void correct() //Cuando la respuesta elegida es correcta
	{ 
		score += 1;
		numeroactual += 1;
		QA.RemoveAt(currentQuestion);
		GenerarPregunta();
	}

	public void SetAnswer()
	{
		for(int i=0; i < opciones.Length; i++){
			opciones[i].GetComponent<RespuestasScriptFinal>().isCorrect = false;
			opciones[i].transform.GetChild(0).GetComponent<Text>().text = QA[currentQuestion].Answers[i];

			if(QA[currentQuestion].CorrectAnswer == i+1)
			{
				opciones[i].GetComponent<RespuestasScriptFinal>().isCorrect = true;
			}
		}
	}

/*public void GenerarPregunta(){
		preguntaActual = Random.Range(0, QA.Count);
		Preguntatxt.text = QA[preguntaActual].Question;
		SetAnswer();
	}

*/
	public void GenerarPregunta() //Actualizado para que no rebase la cantidad de preguntas
	{ 
		PreguntaActualTxt.text = "Pregunta " + numeroactual + " de " + totalQuestion + ": " ;
		if(QA.Count > 0 )
		{
			currentQuestion = Random.Range(0, QA.Count);
			Preguntatxt.text = QA[currentQuestion].Question;
			SetAnswer();
		}
		else
		{
			Debug.Log("Fuera de rango");
			GameOver();
		}
	}

		public void GameOver() //Método que se llama cuando terminamos todas las preguntas, aqui se guardaria en el archivo, en teoria
	{
		PanelPreguntas.SetActive(false);
		PanelRety.SetActive(true);
		Scoretxt.text = score + "/" + totalQuestion;
		 if (Directory.Exists(createDirectory))
		 {	
		 	StreamWriter sw = File.CreateText(Application.persistentDataPath + "/ResultadosCuestionarioFinal/"+ GenerarCaracteresRandom() + ".txt");  
                		sw.Write("Nombre: "+ ScriptCuestion.variable + "\n"+ "Boleta: " + ScriptCuestion.variable1 + "\n" + "Calificación: " + score);
                		sw.Close();
		 }else{ //Si no existe pues se crea la carpeta
		 		Directory.CreateDirectory(createDirectory);
		 		StreamWriter sw = File.CreateText(Application.persistentDataPath + "/ResultadosCuestionarioFinal/"+ GenerarCaracteresRandom() + ".txt");
                			sw.Write("Nombre: "+ ScriptCuestion.variable + "\n"+ "Boleta: " + ScriptCuestion.variable1 + "\n" +  "Calificación: " + score);
                			sw.Close();
            	}	 
	}

	public void retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void wrong() //Cuando contestas una pregunta mal
	{
		numeroactual += 1;
		QA.RemoveAt(currentQuestion);
		GenerarPregunta();
	}

	//genero un char random para pasarlo como parametro.... meramente es el nombre
	public static string GenerarCaracteresRandom()
	{
		var AllChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		var length = 10;

		var randomChars = new char[length];

		for (var r = 0; r < length; r++)
		{
			randomChars[r] = AllChar[UnityEngine.Random.Range(0, AllChar.Length)];
		}
		return new string (randomChars);
	}
}
