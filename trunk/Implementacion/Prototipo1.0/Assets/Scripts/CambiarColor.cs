using UnityEngine;
using System.Collections;

public class CambiarColor : MonoBehaviour {
public Transform[] elementosAVisualizar;
	public Transform padroImageTarget;
	private Transform elemento;
	// Use this for initialization
	void Start () {
	/*TextMesh texto= marcador.GetComponentInChildren<TextMesh>();
		texto.color=Color.red;*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void CambiarColorTexto(int indice){
		elemento=elementosAVisualizar[indice];
		//elemento.parent=padroImageTarget;
		TextMesh texto=elemento.GetComponent<TextMesh>();
		texto.color=Color.red;
	}
	public void VolverAlBlanco(int indice){
		elemento=elementosAVisualizar[indice];
		TextMesh texto=elemento.GetComponent<TextMesh>();
		texto.color=Color.white;
		
	}
}
