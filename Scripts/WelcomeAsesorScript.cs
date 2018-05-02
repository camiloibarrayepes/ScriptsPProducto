using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEngine.SceneManagement;
public class WelcomeAsesorScript : MonoBehaviour {

	private string asesor_name;
	private string asesor_id;
	private string asesor_email;
	private string codigo_concesionario;

	string queryConcesionario = "https://kapta.biz/pproducto/get_concesionario_from_code.php";
	string Logout = "https://kapta.biz/pproducto/logout.php";

	public Text asesor_name_text;
	public Text concesionario_text;

	public string cod_concesionario;


	// Use this for initialization
	void Start () {

		asesor_name = LoginAsesorSQL.asesor_var_name;
		asesor_id = LoginAsesorSQL.asesor_var_id;
		asesor_email = LoginAsesorSQL.asesor_var_email;
		codigo_concesionario = LoginAsesorSQL.asesor_var_id_c;

		asesor_name_text.text = asesor_name;

		WWWForm form = new WWWForm ();
		cod_concesionario = codigo_concesionario;
		form.AddField ("idconcesionario", cod_concesionario);
		WWW wwwstate = new WWW (queryConcesionario, form);
		StartCoroutine (getConcesionario (wwwstate));

		Debug.Log (asesor_name + " " + asesor_id + " " + asesor_email + " " + codigo_concesionario);


	}

	IEnumerator getConcesionario(WWW wwwstate)
	{
		yield return wwwstate;
		concesionario_text.text = wwwstate.text;
		Debug.Log ("RESULTADO " + wwwstate.text);
	}


	public void logout()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("idPost", asesor_id);
		WWW wwwstateasesor = new WWW (queryConcesionario, form);
		StartCoroutine (getConcesionario (wwwstateasesor));
	}

	IEnumerator logout(WWW wwwstateasesor)
	{
		yield return wwwstateasesor;
		Debug.Log ("LOGOUT" + wwwstateasesor.text);
	}


}
