using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pared : MonoBehaviour {

	public Material Color;

	public int tamaño= 10;

	public delegate void metodoDelegado ();
	public static event metodoDelegado Evento;


	void OnCollisionEnter(Collision c){
		if(c.gameObject.name== "ItemB")
			if(Evento != null)
		  		Evento ();
	}
		
	void cambiarcolor(){
		this.gameObject.GetComponent<MeshRenderer> ().material = Color;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnEnable(){
		Evento += cambiarcolor;
	}

	void OnDisable()
	{
		Evento -= cambiarcolor;
	}

	/*public void SliderChange(){
	
		this.gameObject.transform.localScale = new Vector3(,2,2);
	
	}*/





}
