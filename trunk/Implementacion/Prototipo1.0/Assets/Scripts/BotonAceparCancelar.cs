using UnityEngine;
using System.Collections;

public class BotonAceparCancelar : MonoBehaviour {
	private Rect Aceptar;// = new Rect(50,50,100,30);
	private Rect Cancelar;
	private Rect Caja;
	private bool MostrarBoton;
	public GUISkin miGui;
	public Transform ControladorAplicacion; 
	// Use this for initialization
	void Start () {
		MostrarBoton=false;
	    float y=Screen.height/2-30;
	    float x= Screen.width/2-90;
		Aceptar=new Rect(x-100,y,180,60);
	    Cancelar=new Rect(x+100,y,180,60);
		Caja=new Rect(Screen.width/2-250,Screen.height/2-125-10,500,250);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		if(miGui){
			GUI.skin=miGui;
		}
		   if(MostrarBoton){
            GUI.Box(Caja,"Aceptar Pedido");
            // draw the GUI button
            if (GUI.Button(Aceptar, "Aceptar")) {
				 StartCoroutine(recebeString());
                 MostrarBoton=false;
            }
		    if (GUI.Button(Cancelar, "Cancelar")) {
                MostrarBoton=false;
            }
		}
        
    }
		IEnumerator recebeString(){
		        VisualizadorElementos visualizadorElementos=  ControladorAplicacion.GetComponent<VisualizadorElementos>();
				int indice=visualizadorElementos.devolverIndice();
				Debug.Log("indice: "+indice);
				string urlServidor="http://192.168.0.14/prototipo/guardar_bd.php?";
				string post_url = urlServidor +"&indice=" + indice;
		        WWW palabra=new WWW(post_url);
		        yield return palabra;
		        if(palabra.error==null){
			        Debug.Log(palabra.text);
		        }else{
			        Debug.Log(palabra.error);
		        }
	}
	public void CambiarEstadoMostrarBoton(){
		MostrarBoton=true;
	}
}
