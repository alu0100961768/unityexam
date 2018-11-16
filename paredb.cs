using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredb : MonoBehaviour {

	public paredc scriptparedc;

	public delegate void metodoDelegadoB ();
	public static event metodoDelegadoB EventoB;

	//Tendría que crear otro delegado EventoB color y asignarle una funcion para editar todos los objetos tiop B, pero no logro entender la GUI


	void OnCollisionEnter(Collision c){
		if(c.gameObject.name== "ItemA")
			if(EventoB != null)
				EventoB ();
	}

	void cambiarC(){
		scriptparedc.tamañodelegado ();
	}

	// Update is called once per frame
	void OnEnable(){
		EventoB += cambiarC;
	}

	void OnDisable()
	{
		EventoB -= cambiarC;
	}
}
