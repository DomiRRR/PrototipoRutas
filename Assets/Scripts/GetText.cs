using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class GetText : MonoBehaviour
{
	//Where to place the text lines when spawned in 3D space
	public Transform contentWindow; //scrollview -> content -> text
	public Text textito;
	//Where to place the text lines when spawned in 3D space

	public string todoMiTexto;
	public string lectura;

	//string [] namesArray;
	//string myFilePath;

	void Start()
	{
		//lo que esta haciendo aqui es consultar de la persistencia de datos la carpeta de resultados
		DirectoryInfo d = new DirectoryInfo(Application.persistentDataPath + "/ResultadosCuestionarioInicial/");//Assuming Test is your Folder
		//En esta linea busca todos aquellos que tengan la extensión .txt
		FileInfo[] Files = d.GetFiles("*.txt"); 
		
		//En esta parte se pone el texto que lo haga solo una vez al entrar al for each
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
			textito.GetComponent<Text>().text += todoMiTexto;
			todoMiTexto = "";
			lectura = "";
	}
}



//string[] lines = System.IO.File.ReadAllLines(Files);

		//myFilePath = (d + Files);

		//namesArray = File.ReadAllLines(myFilePath);
		//List<string> fileLines = File.ReadAllLines(myFilePath).ToList();

				//Debug.Log(file);
				//textito.GetComponent<Text>().text += (file + "\n" ) //Esto muestra la ruta donde estan estos dos txt
				//foreach(string line in lines)
				//{
					//textito.GetComponent<Text>().text += (line + "\n" );
				//}		
