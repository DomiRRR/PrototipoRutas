using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using UnityEngine.Animations;

public class GameController : MonoBehaviour
{
	public Animator anim;

	public GameObject UICamaraPrincipal;

	public GameObject UICamaraSecundaria;

	public Button Botoncito;

	//public static GameController game; //Para hacerlo un Singletone

	/* void Awake() 
    {
        if(GameController.game == null){
            //Significa que es la primera vez que ocurre esto
            GameController.game = this;
            DontDestroyOnLoad (gameObject);
        }else{
            //Ya hay una instancia, eliminar en ese caso
            Destroy(gameObject);
        }

    }
    */

	void start(){
		anim = GetComponent<Animator>();
		Botoncito = GetComponent<Button>();
	}

	public void botonCambioEscena(){
			UICamaraPrincipal.SetActive(false); //Desactivar la cámara 1
			UICamaraSecundaria.SetActive(true); //Activar la cámara 2
			GameObject.FindWithTag("Iniciar").active=false; //Quitar el botón de iniciar al momento que inicia la cámara 2
			anim.SetTrigger("Camara");
	} 	


}
