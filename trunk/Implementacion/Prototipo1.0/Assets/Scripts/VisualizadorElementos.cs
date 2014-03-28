using UnityEngine;
using System.Collections;

public class VisualizadorElementos : MonoBehaviour {
   public Transform[] elementosAVisualizar;
   public Transform padroImageTarget;
   private Transform elemento;	
	private CambiarColor cambiarColor;
	private int i;
	// Use this for initialization
	void Start () {
	    i=0;
		elemento= Instantiate(elementosAVisualizar[i],elementosAVisualizar[i].transform.position,elementosAVisualizar[i].rotation) as Transform;
		elemento.parent=padroImageTarget;
		cambiarColor=GetComponent<CambiarColor>();
		cambiarColor.CambiarColorTexto(i);
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}
	public void GenerarSiguienteElemento(){
		cambiarColor.VolverAlBlanco(i);
		Destroy(elemento.gameObject);
		i=Siguiente(i); 
		elemento= Instantiate(elementosAVisualizar[i],elementosAVisualizar[i].transform.position,elementosAVisualizar[i].rotation) as Transform;
		elemento.parent=padroImageTarget;
		cambiarColor.CambiarColorTexto(i);
	}
	public void GenerarAnteriorElemento(){
			cambiarColor.VolverAlBlanco(i);
		    Destroy(elemento.gameObject);
			i=Anterior(i); 
			elemento= Instantiate(elementosAVisualizar[i],elementosAVisualizar[i].transform.position,elementosAVisualizar[i].rotation) as Transform;
			elemento.parent=padroImageTarget;
		    cambiarColor.CambiarColorTexto(i);
	}

	public int Siguiente(int indice){
		if(indice==4){
			return 0;
		}else{
			indice=indice+1;
			return indice;
		}
			
	}
	public int Anterior(int indice){
		if(indice==0){
			return 4;
		}else{
			indice=indice-1;
			return indice;
		}
	}
	public int devolverIndice(){
		return i;
	}
}
