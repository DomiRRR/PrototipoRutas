using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class GetTextCFin : MonoBehaviour
{
	public Transform contentWindow;
	public Text textito;

	public string todoMiTexto;
	public string lectura;

	//public string createDirectory; 

	void Start()

	//createDirectory = Application.persistentDataPath + "/ResultadosCuestionarioFinal";

	{
		DirectoryInfo d = new DirectoryInfo(Application.persistentDataPath + "/ResultadosCuestionarioFinal/");
				 if (Directory.Exists(Application.persistentDataPath + "/ResultadosCuestionarioFinal"))
				 {
				 	FileInfo[] Files = d.GetFiles("*.txt"); 
		
					Instantiate(textito, contentWindow); 
					textito.GetComponent<Text>().text = "";
					foreach(FileInfo file in Files )
				{
					Debug.Log(file);
					FileStream fStream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
					StreamReader reader =  new StreamReader(fStream);
					lectura = reader.ReadToEnd();
					todoMiTexto += lectura + "\n";
					reader.Close();
					fStream.Close();
				}
				}else
				{
					textito.GetComponent<Text>().text = "No se ha realizado el cuestionario final, no existen datos";
				}
				textito.GetComponent<Text>().text += todoMiTexto;
				todoMiTexto = "";
				lectura = "";

		}	
}