using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CuadroDialogo2 : MonoBehaviour
{
  public GameObject Panel;

  public Button BotonSi;
  public Button BotonNo;

  public Button Element1;
  public Button Element2;
  public Button Element3;
  public Button Element4;

  void start(){
		BotonSi = GetComponent<Button>();
		BotonNo = GetComponent<Button>();
		Element1 = GetComponent<Button>();
		Element2 = GetComponent<Button>();
		Element3 = GetComponent<Button>();
		Element4 = GetComponent<Button>();
	}


 public void CuadroConfirmación(){ //Este aparece cuando se le da al botón de regresar
	Panel.SetActive(true); //Aparece el POP-UP con los botones de si o no
	Element1.enabled = false;  //No permite al usuario seleccionar el boton hasta cerrar el POP-UP
    Element2.enabled = false;
    Element3.enabled = false;
    Element4.enabled = false;
}

public void VolverMenu(){  //Si el usuario da al botón SI, vuelve al menú principal
         SceneManager.LoadScene("CPrincipal");

}

public void Quedarse(){ //Si el usuario da al botón NO, reanuda el recorrido
	Panel.SetActive(false); //Desaparece el POP-UP
	Element1.enabled = true; //Permite la selección del botón otra vez
    Element2.enabled = true;
    Element3.enabled = true;
    Element4.enabled = true;
}

}
