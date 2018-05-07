using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEngine.SceneManagement;

public class Consulta
{
	public string Textoconsulta;
	public string Usuario;
	public string id_usuario_consulta;
	public string pregunta;
}

public class consultaAsesor : MonoBehaviour {



	public string codigo_concesionario;

	public Text solicitudes;

	string verSolicitudes = "https://kapta.biz/pproducto/get_consultas.php";

	public GameObject PrefabConsulta;

	public Transform ContenedorConsulta;

	// Use this for initialization
	void Start () {

		codigo_concesionario = LoginAsesorSQL.asesor_var_id_c;
		Debug.Log ("COD CON " + codigo_concesionario);

		WWWForm form = new WWWForm ();
		form.AddField ("codconcesionarioPost", codigo_concesionario);
		WWW wwwstate = new WWW (verSolicitudes, form);
		StartCoroutine (verSolicitudesRequest (wwwstate));
	}

	IEnumerator verSolicitudesRequest(WWW wwwstate)
	{
		yield return wwwstate;


		Debug.Log ("RESULTADO SCRIPT CONSULTA ASESOR " + wwwstate.text);
		string[] wordsConsultas = wwwstate.text.Split (';');


		for (int con = 0; con < wordsConsultas.Length; con++) 
		{
			string[] subwordsConsultas = wordsConsultas[con].Split(',');

				if (!string.IsNullOrEmpty (wordsConsultas [con])) {
					List<Consulta> LConsul = new List<Consulta> {
					new Consulta{ 
						id_usuario_consulta = subwordsConsultas [0],  
						Textoconsulta = subwordsConsultas [1], 
						Usuario = subwordsConsultas [2], 
						pregunta = subwordsConsultas[3] }
					};

					foreach (var itemCon in LConsul) {
						GameObject _consulta = Instantiate (PrefabConsulta, ContenedorConsulta);
						_consulta.GetComponent<DetallesConsulta> ().CrearConsutla (itemCon);
					}
				}
			

		}

	}

	public void btnAtras()
	{
		SceneManager.LoadScene("WelcomeAsesor");
	}

}
