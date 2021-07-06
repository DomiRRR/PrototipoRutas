using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicloAnim : MonoBehaviour
{
	//El Ciclo de Krebs cuenta con las ENZIMAS

	/*
	o	Citrato sintasa.
	o	Aconitasa.
	o	Isocitrato deshidrogenasa.
	o	α-cetoglutarato deshidrogenasa.
	o	Succinil-CoA sintetasa.
	o	Succinato deshidrogenasa.
	o	Fumarasa.
	o	Malato deshidrogenasa.
	*/

	public Animator Oxalacetato;
	public Animator pacetil;
	public Animator CitratoEnzim;
	public Animator Citrato;
	public Animator AconitasaEnzim;
	public Animator Isocitrato;
	public Animator IsocitratoEnzim;
	public Animator Alfaceto;
	public Animator alfacetaEnzim;
	public Animator SuccinilCOA;
	public Animator SuccinilEnzim;
	public Animator Succinato;
	public Animator SuccinatoEnzim;
	public Animator Fumarato;
	public Animator FumarasaEnzim;
	public Animator Malato;
	public Animator MalatoDeshiEnzim;
	public Animator GTP;
	public Animator GDP;
	public Animator NADH;
	public Animator NADMAS;
	public Animator CO2;
	public Animator FAD;
	public Animator FADH2;
	public Animator NADMas2;
	public Animator NADHDos;
	public Animator Agua;
	public Animator ADP;
	public Animator ATP;
	public Animator Agua2;
	public Animator NAD3;
	public Animator NADH3;
	public Animator OxalaFinal;
	public Animator Ciclo;

    void start()
    {
     	Oxalacetato = GetComponent<Animator>();
     	pacetil = GetComponent<Animator>();
     	CitratoEnzim = GetComponent<Animator>();
    	Citrato = GetComponent<Animator>();
    	AconitasaEnzim = GetComponent<Animator>();
    	Isocitrato = GetComponent<Animator>();
    	IsocitratoEnzim = GetComponent<Animator>();
    	Alfaceto = GetComponent<Animator>();
    	alfacetaEnzim = GetComponent<Animator>();
    	SuccinilCOA = GetComponent<Animator>();
    	SuccinilEnzim = GetComponent<Animator>();
    	Succinato = GetComponent<Animator>();
    	SuccinatoEnzim = GetComponent<Animator>();
    	Fumarato = GetComponent<Animator>();
    	FumarasaEnzim = GetComponent<Animator>();
    	Malato = GetComponent<Animator>();
    	MalatoDeshiEnzim = GetComponent<Animator>();
    	GTP = GetComponent<Animator>();
    	GDP = GetComponent<Animator>();
    	NADH = GetComponent<Animator>();
    	NADMAS = GetComponent<Animator>();
    	CO2 = GetComponent<Animator>();
    	FAD = GetComponent<Animator>();
    	FADH2 = GetComponent<Animator>();
    	NADMas2 = GetComponent<Animator>();
    	NADHDos = GetComponent<Animator>();
    	Agua = GetComponent<Animator>();
    	ADP = GetComponent<Animator>();
    	ATP = GetComponent<Animator>();
    	Agua2 = GetComponent<Animator>();
    	NAD3 = GetComponent<Animator>();
    	NADH3 = GetComponent<Animator>();
    	OxalaFinal = GetComponent<Animator>();
    	Ciclo = GetComponent<Animator>();
     }

    public void EmpezarPiruacetil()
        {
        	pacetil.SetTrigger("Encender");
        }

    public void EmpezarCitratoEnzim()
		{
			CitratoEnzim.GetComponent<Animator>().SetTrigger("Encender");
		}

	public void EmpezarCitrato() 
	    {
	    	Citrato.SetTrigger("Encender");
	    }
	public void EmpezarAconitasaEnzim()
		{
			AconitasaEnzim.SetTrigger("Encender");
		}
	public void EmpezarIsocitrato() 
	    {
	    	Isocitrato.SetTrigger("Encender");
	    }
	public void EmpezarIsocitratoEnzim()
		{
			IsocitratoEnzim.SetTrigger("Encender");
		}
	public void EmpezarAlfaceto() 
	    {
	    	Alfaceto.SetTrigger("Encender");
	    }
	public void EmpezaralfacetaEnzim()
		{
			alfacetaEnzim.SetTrigger("Encender");
		}
	public void EmpezarSuccinil() 
	    {
	    	SuccinilCOA.SetTrigger("Encender");
	    }
	public void EmpezarSuccinilEnzim()
		{
			SuccinilEnzim.SetTrigger("Encender");
		}
	public void EmpezarSuccinato() 
	    {
	    	Succinato.SetTrigger("Encender");
	    }
	public void EmpezarSuccinatoEnzim()
		{
			SuccinatoEnzim.SetTrigger("Encender");
		}
	public void EmpezarFumarato()
	    {
	    	Fumarato.SetTrigger("Encender");
	    } 
	public void EmpezarFumarasaEnzim()
		{
			FumarasaEnzim.SetTrigger("Encender");
		}
	public void EmpezarMalato()
	    {
	    	Malato.SetTrigger("Encender");
	    } 
	public void EmpezarMalatoDeshiEnzim()
		{
			MalatoDeshiEnzim.SetTrigger("Encender");
		}
	public void EmpezarGTP()
	    {
	    	GTP.SetTrigger("Encender");
	    } 
	public void EmpezarGDP()
	    {
	    	GDP.SetTrigger("Encender");
	    } 
	public void EmpezarNADH()
	    {
	    	NADH.SetTrigger("Encender");
	    } 
	public void EmpezarNADMas()
	    {
	    	NADMAS.SetTrigger("Encender");
	    }
	public void EmpezarCOdos()
	    {
	    	CO2.SetTrigger("Encender");
	    }
	public void EmpezarFAD()
	    {
	    	FAD.SetTrigger("Encender");
	    }
	public void EmpezarFADEH2()
	    {
	    	FADH2.SetTrigger("Encender");
	    }    

	public void EmpezarNadMas2()
		{
			NADMas2.SetTrigger("Encender");
		}
	public void EmpezarNadHdos()
		{
			NADHDos.SetTrigger("Encender");
		}
	public void EmpezarAgua()
		{
			Agua.SetTrigger("Encender");	
		}
	public void EmpezarADP()
		{
			ADP.SetTrigger("Encender");
		}
	public void EmpezarATP()
		{
			ATP.SetTrigger("Encender");
		}
	public void EmpezarAgua2()
		{
			Agua2.SetTrigger("Encender");
		}
	public void EmpezarNad3()
		{
    		NAD3.SetTrigger("Encender");
		}
	public void EmpezarNADH3()
		{
    	    NADH3.SetTrigger("Encender");
		}
	public void EmpezarOxalaFinal()
		{
			OxalaFinal.SetTrigger("Encender");
		}
	public void Rutaciclo()
		{
			Ciclo.SetTrigger("Encender");
		}
}
