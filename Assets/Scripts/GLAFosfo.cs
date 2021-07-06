using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLAFosfo : MonoBehaviour
{
	//El gran complejo de la ATP sintasa

	/*
	o	ATP Sintasa...
	*/ 
    public Animator Sintasa;
	public Animator ATP;

   void start(){
		Sintasa = GetComponent<Animator>();
		ATP = GetComponent<Animator>();
	}

public void EmpezarAtps() 
	{
			ATP.SetTrigger("Empezo");
	} 	
}
