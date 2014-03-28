/*==============================================================================
Copyright (c) 2010-2013 QUALCOMM Austria Research Center GmbH.
All Rights Reserved.
==============================================================================*/

using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This class implements the IVirtualButtonEventHandler interface and
/// contains the logic to swap materials for the teapot model depending on what 
/// virtual button has been pressed.
/// </summary>
public class VirtualButtonEventHandler : MonoBehaviour,
                                         IVirtualButtonEventHandler
{
    #region PUBLIC_MEMBER_VARIABLES

    /// <summary>
    /// The materials that will be set for the teapot model
    /// </summary>
    public Transform ControladorAplicacion; 

    #endregion // PUBLIC_MEMBER_VARIABLES



    #region PRIVATE_MEMBER_VARIABLES
    


    #endregion // PRIVATE_MEMBER_VARIABLES



    #region UNITY_MONOBEHAVIOUR_METHODS

    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS



    #region PUBLIC_METHODS
    
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");
		VisualizadorElementos visualizadorElementos=  ControladorAplicacion.GetComponent<VisualizadorElementos>();

        // Add the material corresponding to this virtual button
        // to the active material list:
        switch (vb.VirtualButtonName)
		
        {
            case "anterior":
			    Debug.Log("Anterior");
			   visualizadorElementos.GenerarAnteriorElemento(); 
                break;

            case "siguiente":
                Debug.Log("Siguiete");
			    visualizadorElementos.GenerarSiguienteElemento();
                break;
			
		    case "botonGuardar":
                Debug.Log("botonGuardar");
	            GameObject camara=GameObject.Find("ARCamera");
			    BotonAceparCancelar botonAceparCancelar=camara.GetComponent<BotonAceparCancelar>();
			    botonAceparCancelar.CambiarEstadoMostrarBoton();// cambia la variable MostrarBoton en true
			    break;

        }
    }


    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
 
        // Remove the material corresponding to this virtual button
        // from the active material list:
        switch (vb.VirtualButtonName)
        {
            case "anterior":
                Debug.Log("Anterior Saliendo");
                break;

            case "siguiente":
                Debug.Log("Siguiete Saliendo");
                break;
			
			case "botonGuardar":
                Debug.Log("botonGuardar Saliendo");
			    break;
        }

    }



    #endregion // PUBLIC_METHODS
}
