using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEngine.SceneManagement;


public class consulta : MonoBehaviour {

	string contulatQuery = "https://kapta.biz/pproducto/consulta.php";
	public InputField consultaUsuario;
	public InputField pregunta;

	public string concesionario_elegido;
	public string getusername;
	// Use this for initialization
	void Start () {

		//limitar caracteres
		consultaUsuario.characterLimit = 100;
		pregunta.characterLimit = 100;

		getusername = LoginUserSQL.var_name;
		concesionario_elegido = SceneManagerScript.nombre_concesionario;
		Debug.Log ("CON EG " + concesionario_elegido);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void solicitar()
	{
		CreateConsulta (consultaUsuario.text, pregunta.text, concesionario_elegido, getusername);
		SceneManager.LoadScene("SolicitarEspera");
	}

	public void CreateConsulta(string consulta, string pregunta, string concesionario_elegido, string getusername)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("consulta", consulta);
		form.AddField ("pregunta", pregunta);
		form.AddField ("concesionario_string", concesionario_elegido);
		form.AddField ("UserName", getusername);
		WWW www = new WWW (contulatQuery, form);
		StartCoroutine (queryConsulta (www));
	}

	IEnumerator queryConsulta(WWW www)
	{
		yield return www;
		Debug.Log ("WWW RESPUESTA " + www.text);
	}

	public void volverMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
