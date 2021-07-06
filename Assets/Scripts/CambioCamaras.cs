using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamaras : MonoBehaviour
{
	public GameObject UICamaraPrincipal;

	public GameObject UICamaraSecundaria;

	public void botonCambioEscena(){
		UICamaraPrincipal.SetActive(false);
		UICamaraSecundaria.SetActive(true);
	}
}
