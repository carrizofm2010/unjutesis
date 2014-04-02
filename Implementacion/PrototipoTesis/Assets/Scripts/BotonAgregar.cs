using UnityEngine;
using System.Collections;

public class BotonAgregar : MonoBehaviour {
	
	private Rect agregar;
	public GUISkin miGUI;
	// Use this for initialization
	void Start () {
		this.construirBoton();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void construirBoton (){
	
		agregar = new Rect (Screen.width/2-50+150,Screen.height/2-25-90 ,100,50);
		
	}
	
	void OnGUI(){
		if (miGUI){
		GUI.skin=miGUI;
	}
		if (GUI.Button(agregar,"Agregar")){
				Debug.Log("boton presionado");
		}
	}
}
