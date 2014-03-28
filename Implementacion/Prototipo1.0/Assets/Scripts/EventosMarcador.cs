using UnityEngine;
using System.Collections;

public class EventosMarcador : MonoBehaviour {
	
	public GUIText notificacion;
	

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
	
	public void MarcadorEncontrado ()
	{
		if (notificacion != null) {
			notificacion.enabled = false;
		}

	}
	
	public void MarcadorPerdido ()
	{
		if (notificacion != null) {
			notificacion.enabled = true;
		}
		
	}
	
}
