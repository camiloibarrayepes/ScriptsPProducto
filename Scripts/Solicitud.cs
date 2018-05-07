using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Solicitud : MonoBehaviour {


	public Text consulta;
	public Text usuario;
	public Text id_consulta;
	public Text pregunta;

	public string asesor_id;

	string atenderConsulta = "https://kapta.biz/pproducto/atender_consulta.php";


	// Use this for initialization
	void Start () {
		consulta.text = DetallesConsulta.consulta;
		pregunta.text = DetallesConsulta.getpregunta;
		usuario.text = DetallesConsulta.getusuario;
		id_consulta.text = DetallesConsulta.id_consulta;
		asesor_id = LoginAsesorSQL.asesor_var_id;
		Debug.Log ("ASESOR ID " + asesor_id);

		WWWForm form = new WWWForm ();
		form.AddField ("id_consulta", DetallesConsulta.id_consulta);
		form.AddField ("id_asesor", asesor_id);
		WWW wwwstate = new WWW (atenderConsulta, form);

	}


	
	// Update is called once per frame
	void Update () {
		
	}

	public void Volver()
	{
		SceneManager.LoadScene ("VerSolicitudes");
	}
}
