using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetallesConsulta : MonoBehaviour {
	

	public Text Textoconsulta;
	public Text Usuario;
	public Text id_usuario_consulta;
	public Text pregunta;

	public static string consulta;
	public static string getusuario;
	public static string id_consulta;
	public static string getpregunta;

	// Use this for initialization
	void Start () {
		
	}
	
	public void CrearConsutla(Consulta consulta)
	{
		Textoconsulta.text = consulta.Textoconsulta;
		Usuario.text = consulta.Usuario;
		id_usuario_consulta.text = consulta.id_usuario_consulta;
		pregunta.text = consulta.pregunta;
	}

	public void GetConsulta()
	{
		
		consulta = Textoconsulta.text;
		getusuario = Usuario.text;
		id_consulta = id_usuario_consulta.text;
		getpregunta = pregunta.text;

		SceneManager.LoadScene ("Solicitud");
		
		Debug.Log ("ID" + id_usuario_consulta.text + "Usuario " + Usuario.text + "Consulta " + Textoconsulta.text + "Pregunta " + pregunta);
	}

}
