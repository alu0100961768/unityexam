using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredc : MonoBehaviour {

	//public Material Color;
	//public GameObject Objeto;

	public delegate void metodoDelegadoC ();
	public static event metodoDelegadoC EventoC;


	/*void OnCollisionEnter(Collision c){
		if(c.gameObject.name== "ItemB")
		if(Evento != null)
			Evento ();
	}*/


	public void tamañodelegado(){
		if(EventoC != null)
			EventoC ();
	}

	void cambiartamaño(){
		this.gameObject.transform.localScale += new Vector3(2,2,2);
	}

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void OnEnable(){
		EventoC += cambiartamaño;
	}

	void OnDisable()
	{
		EventoC -= cambiartamaño;
	}

}
