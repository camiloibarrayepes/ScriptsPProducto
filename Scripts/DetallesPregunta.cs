using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetallesPregunta : MonoBehaviour {

	public string id_question_value;
	public string option_value;

	public Text id_question;
	public Text id_opcion;
	public Text question;

	public static int static_id_question_value;
	public static string static_option_value;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CrearPregunta(Pregunta pregunta)
	{
		id_question.text = pregunta.id_question.ToString();
		id_opcion.text = pregunta.option;
		question.text = pregunta.question;
	}


	public void GoToSubCategories()
	{
		//Igualo Value al valor de Nombre, segun la categoria
		id_question_value = id_question.GetComponent<UnityEngine.UI.Text> ().text;
		option_value =  question.GetComponent<UnityEngine.UI.Text> ().text;
		Debug.Log ("IDQUI " + id_question_value);
		Debug.Log ("QUESTIONQUI " + option_value);
	}

}
