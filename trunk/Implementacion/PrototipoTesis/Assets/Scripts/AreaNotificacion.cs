using UnityEngine;
using System.Collections;

public class AreaNotificacion : MonoBehaviour {
	public GUITexture imagenBotonAreaNotificacion;
	private bool botonAreaNotificacionPulsado=false;
	// Use this for initialization
	void Start () {
	this.situarBotones();
	}
	
	// Update is called once per frame
	void Update () {
			 if(Input.touchCount > 0){
             for (var i = 0; i < Input.touchCount; ++i) { 
		           if(imagenBotonAreaNotificacion.HitTest(Input.GetTouch(i).position)){
						if(Input.GetTouch(i).phase==TouchPhase.Ended){
						 botonAreaNotificacionPulsado = true;    
					} 
               
				}
			}
		}
		if(botonAreaNotificacionPulsado){
           Debug.Log("Area de notificacion activada");
	       
        }
		botonAreaNotificacionPulsado = false;
	
	}
	public void situarBotones(){
		imagenBotonAreaNotificacion.transform.position = Vector3.zero;
        imagenBotonAreaNotificacion.transform.localScale = Vector3.zero; 
	    imagenBotonAreaNotificacion.guiTexture.pixelInset=new Rect(Screen.width/2-40-120,Screen.height/2-40,80,80);
	}
}
