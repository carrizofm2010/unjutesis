using UnityEngine;
using System.Collections;

public class Salir : MonoBehaviour {
	void Update () {
			if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();// saliendo de la aplicacion
		}
	
	}
}
