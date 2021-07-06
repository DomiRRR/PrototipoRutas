using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLAnima : MonoBehaviour
{

//La glucólisis cuenta con 10 fases (ENZIMAS)

	/*
	o	Hexoquinasa.
	o	Fosfoglucosa isomerasa (Glucosa-6 P isomerasa) 
	o	Fosfofructoquinasa.
	o	Aldolasa.
	o	Trifosfato isomerasa.
	o	Glyceraldehyde-3-phosphate Dehydrogenase.
	o	Fosfoglicerato quinasa.
	o	Fosfoglicerato mutasa.
	o	Enolasa
	o	Piruvato kinasa
	*/

	public Animator Glucosa;
	public Animator EnzimHexo; //Primera enzima
	public Animator ATP;
	public Animator Fosfato;
	public Animator Glc6Fos;
	public Animator ADP;
	public Animator EnzimIsomer; //Segunda enzima
	public Animator Fruc6Fos;
	public Animator EnzimFosfofruct; //Tercera enzima
	public Animator Frucbifos;
	public Animator EnzimAldola; //Cuarta enzima
	public Animator Dihifos;
	public Animator Glicefos;
	public Animator EnzimTriosaIsom; //Quinta enzima
	public Animator EnzimGlicefosdeshi; //Sexta enzima
	public Animator NAD;
	public Animator bifosfa;
	public Animator NADH;
	public Animator EnzimFosfokina; //Séptima enzima
	public Animator tresFosfo;
	public Animator EnzimFosfoMuta; //Octava enzima
	public Animator dosFosfo; 
	public Animator EnzimEnolasa; //Novena enzima
	public Animator Fosfoenol; 
	public Animator H20; //Molécula de AGUA
	public Animator EnzimPiKina; //Décima enzima Piruvato KINASA
	public Animator Piruvato; 
	public Animator ATP2;
	public Animator Glice2; //Gliceraldehido 2 por que la dihidro no podia seguir la ruta
	public Animator ADP2; // Se ocupa para transformar 1,3-bisfosfato + ADP = 3-fosfoglicerato + ATP
	public Animator ATP3; 
	public Animator ADP3; //creo es el final
	public Animator ATPFinal1;
	public Animator ATPFinal12;
	public Animator piruvatosolo;
	public Animator CoenzimaCOA;

//Tengo que obtener el componente animator para poder acceder a las funciones....
	void start(){
		Glucosa = GetComponent<Animator>();
		EnzimHexo = GetComponent<Animator>();
		ATP = GetComponent<Animator>();
		Fosfato = GetComponent<Animator>();
		Glc6Fos = GetComponent<Animator>();
		ADP = GetComponent<Animator>();
		EnzimIsomer = GetComponent<Animator>();
		Fruc6Fos = GetComponent<Animator>();
		EnzimFosfofruct = GetComponent<Animator>();
		Frucbifos = GetComponent<Animator>();
		EnzimAldola = GetComponent<Animator>();
		Dihifos = GetComponent<Animator>();
		Glicefos = GetComponent<Animator>();
		EnzimTriosaIsom = GetComponent<Animator>();
		EnzimGlicefosdeshi = GetComponent<Animator>();
		NAD = GetComponent<Animator>();
		bifosfa = GetComponent<Animator>();
		NADH = GetComponent<Animator>();
		EnzimFosfokina = GetComponent<Animator>();
		tresFosfo = GetComponent<Animator>();
		EnzimFosfoMuta = GetComponent<Animator>();
		dosFosfo = GetComponent<Animator>();
		EnzimEnolasa = GetComponent<Animator>();
		Fosfoenol = GetComponent<Animator>();
		H20 = GetComponent<Animator>();
		EnzimPiKina = GetComponent<Animator>();
		Piruvato = GetComponent<Animator>();
		ATP2 = GetComponent<Animator>();
		Glice2 = GetComponent<Animator>();
		ADP2 = GetComponent<Animator>();
		ATP3 = GetComponent<Animator>();
		ADP3 = GetComponent<Animator>();
		ATPFinal1 = GetComponent<Animator>();
	    ATPFinal12 = GetComponent<Animator>();
	    piruvatosolo = GetComponent<Animator>();
	    CoenzimaCOA = GetComponent<Animator>();
	}

	public void EmpezarHexo() //Enzima HEXOQUINASA
	{
			EnzimHexo.SetTrigger("Arrastre");
	} 	

	public void EmpezarATP() //Movimento ATP
	{
			ATP.SetTrigger("Mover");
	} 	

	public void EmpezarFosfo() //Movimiento Grupo Fosfato
	{
		Fosfato.SetTrigger("Mover1");
	}

	public void EmpezarGluco6fosfo() //Traer a la camara la molécula transformada GLUCOSA  6 FOSFATO
	{
		Glc6Fos.SetTrigger("Aparecer");
	}

	public void EmpezarADP() //Movimiento de la capsulita ADP
	{
		ADP.SetTrigger("Generar");
	}

	public void EmpezarIsomer()
	{
		EnzimIsomer.SetTrigger("IniciarISO");	
	}

	public void EmpezarFructo6()
	{
		Fruc6Fos.SetTrigger("Cambio");
	}

	
	public void EmpezarFosfoFructo()
	{
		EnzimFosfofruct.SetTrigger("Cambio");
	}

	public void ReproducirATP2()
	{
		ATP2.SetTrigger("Cambio");	
	}

	public void EmpezarFruc16()
	{
		Frucbifos.SetTrigger("Cambio");
		
	}

	public void EmpezarAldolasa()
	{
		EnzimAldola.SetTrigger("Cambio");	
	}

	public void EmpezarDihifos()
	{
		Dihifos.SetTrigger("Cambio");
	}

	public void EmpezarGliceral()
	{
		Glicefos.SetTrigger("Cambio");
	}

	public void EmpezarTriosaFosfa()
	{
		EnzimTriosaIsom.SetTrigger("Cambio");
	}

	public void EmpezarGliceral2()
	{
		Glice2.SetTrigger("Cambio");
	}

	public void EmpezarGli3fosdeshi()
	{
		EnzimGlicefosdeshi.SetTrigger("Cambio");
	}

	public void EmpezarNadmas()
	{
		NAD.SetTrigger("Cambio");
	}

	public void Empezarunotresbifosfo()
	{
		bifosfa.SetTrigger("Cambio");
	}

	public void EmpezarNadH()
	{
		NADH.SetTrigger("Cambio");
	}

	public void EmpezarFosfogliKinasa()
	{
		EnzimFosfokina.SetTrigger("Cambio");
	}

	public void MoverAdp2()
	{
		ADP2.SetTrigger("Cambio");
	}

	public void EmpezartresFosfo()
	{
		tresFosfo.SetTrigger("Cambio");
	}

	public void EmpezarAt3()
	{
		ATP3.SetTrigger("Cambio");
	}

	public void EmpezarFosfogliceraMuta()
	{
		EnzimFosfoMuta.SetTrigger("Cambio");
	}

	public void Empezar2Fosfo()
	{
		dosFosfo.SetTrigger("Cambio");
	}

	public void EmpezarEnolasa()
	{
		EnzimEnolasa.SetTrigger("Cambio");
	}

	public void MoverAgua()
	{
		H20.SetTrigger("Cambio");
	}

	public void EmpezarFosfoenolpiruvato()
	{
		Fosfoenol.SetTrigger("Cambio");
	}

	public void EmpezarPiruvatoKinasa()
	{
		EnzimPiKina.SetTrigger("Cambio");
	}

	public void EmpezarADP3()
	{
	 ADP3.SetTrigger("Cambio");
	}

	public void EmpezarPiruato()
	{
	 Piruvato.SetTrigger("Cambio");
	}

	public void EmpezarATPFINAL()
	{
	 ATPFinal1.SetTrigger("Cambio");
	}

	public void EmpezarATPFINAL1()
	{
	 ATPFinal12.SetTrigger("Cambio");
	}

	public  void EmpezarPiruvatoSolo()
	{
		piruvatosolo.SetTrigger("Cambio");
	}

	public void EmpezarCoenzima()
	{
		CoenzimaCOA.SetTrigger("Cambio");
	}
}
	
