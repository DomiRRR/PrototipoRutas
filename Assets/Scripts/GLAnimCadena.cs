using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLAnimCadena : MonoBehaviour
{
	//La cadena de transportes cuenta con 4 complejos proteicos y 2 coenzimas 

	/*
	o	NADH Deshidrogenasa
	o	Succinato Deshidrogenasa 
	o	CitocromoBC1.
	o	Citocromo Oxidasa.
	o	Coenzima Q10
	o	Complejo del citocromo C
	*/

	public Animator NADHDeshidro;
	public Animator SuccinatoDeshidro;
	public Animator CitoBC;
	public Animator CitoOxi;
	public Animator CoeQ;
	public Animator ComCitC;
	public Animator NADH; 
	public Animator NADMas;
	public Animator FADHDos; 
	public Animator FAD;

	void start(){
		NADHDeshidro = GetComponent<Animator>();
		SuccinatoDeshidro = GetComponent<Animator>();
		CitoBC = GetComponent<Animator>();
		CitoOxi = GetComponent<Animator>();
		CoeQ = GetComponent<Animator>();
		ComCitC = GetComponent<Animator>();
		NADH = GetComponent<Animator>();
		NADMas = GetComponent<Animator>();
		FADHDos = GetComponent<Animator>();
		FAD = GetComponent<Animator>();
	
	}

	public void EmpezarNADH() 
	{
			NADH.SetTrigger("Iniciar");
	} 	
	public void EmpezarNADMas() 
	{
			NADMas.SetTrigger("Iniciar");
	} 	
	public void EmpezarSegundoComplejo() 
	{
			SuccinatoDeshidro.SetTrigger("Iniciar");
	} 	
	public void EmpezarFADH() 
	{
			FADHDos.SetTrigger("Iniciar");
	} 	
	public void EmpezarFAD() 
	{
			FAD.SetTrigger("Iniciar");
	} 	
	public void EmpezarTercerComplejo() 
	{
			CitoBC.SetTrigger("Iniciar");
	} 	
	public void EmpezarPrimeraCoenzima() 
	{
			CoeQ.SetTrigger("Iniciar");
	} 	
	public void EmpezarCuartoComplejo()
	{
			CitoOxi.SetTrigger("Iniciar");
	} 	
	public void EmpezarSegundaCoenzima() 
	{
			ComCitC.SetTrigger("Iniciar");
	} 	
}
