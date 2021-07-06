using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CuadroDialogo : MonoBehaviour
{
  public GameObject Panel;

  public Button BotonSi;
  public Button BotonNo;

  //public static CuadroDialogo animaciones; //Para hacerlo un Singletone

	 /*void Awake() 
    {
        if(CuadroDialogo.animaciones == null){
            //Significa que es la primera vez que ocurre esto
            CuadroDialogo.animaciones = this;
            DontDestroyOnLoad (gameObject);
        }else{
            //Ya hay una instancia, eliminar en ese caso
            Destroy(gameObject);
        }

    }
    */

  void start(){
		BotonSi = GetComponent<Button>();
		BotonNo = GetComponent<Button>();
	}


 public void CuadroConfirmación(){ //Este aparece cuando se le da al botón de regresar
	Panel.SetActive(true); //Aparece el POP-UP con los botones de si o no
}

public void VolverMenu(){  //Si el usuario da al botón SI, vuelve al menú principal
         SceneManager.LoadScene("MenuPri");

}

public void Quedarse(){ //Si el usuario da al botón NO, reanuda el recorrido
	Panel.SetActive(false); //Desaparece el POP-UP
}

}
