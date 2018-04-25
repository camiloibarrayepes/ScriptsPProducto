using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetallesPregunta : MonoBehaviour {

	public Text id_question;
	public Text id_opcion;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CrearPregunta(Pregunta pregunta)
	{
		id_question.text = pregunta.id_question;
		id_opcion.text = pregunta.id_opcion;
	}

}
