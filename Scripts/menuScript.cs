using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public string concesionario_elegido;
	public string user_id;
	string getAsesores = "https://kapta.biz/pproducto/get_asesores_from_idcon.php";

	// Use this for initialization
	void Start () {
		
		concesionario_elegido = SceneManagerScript.nombre_concesionario;
		Debug.Log ("MENU CONCESIONARIO ELEGIDO" + concesionario_elegido);


		WWWForm form = new WWWForm ();
		form.AddField ("concesionario", concesionario_elegido);
		WWW wwwstate = new WWW (getAsesores, form);

		StartCoroutine (FungetAsesores (wwwstate));

	}

	IEnumerator FungetAsesores(WWW wwwstate)
	{
		yield return wwwstate;

		Debug.Log ("RESULTADO ASESORES " + wwwstate.text);
	}
	
	public void logoutUserF()
	{
		SceneManager.LoadScene("LoginUser");
		LoginUserSQL.var_id = "0";

	}


}
