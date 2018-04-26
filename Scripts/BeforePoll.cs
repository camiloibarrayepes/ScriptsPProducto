using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEngine.SceneManagement;

public class BeforePoll : MonoBehaviour {

	string CreateUserURL = "https://kapta.biz/pproducto/get_state_poll_user.php";
		
	private string dataUser;

	public string redirect;

	public int iduserget;

	// Use this for initialization
	void Start () {

		WWWForm form = new WWWForm ();
		iduserget = 2;
		//envio el id de usuario y me devuelve el campo poll 1 o 0
		form.AddField ("idUserPost", iduserget);
		WWW wwwstate = new WWW (CreateUserURL, form);

		StartCoroutine (request (wwwstate));

	}

	IEnumerator request(WWW wwwstate)
	{
		yield return wwwstate;
		dataUser = wwwstate.text;
		Debug.Log ("ITESM DATA PRESENT " + dataUser);
		int m = Int32.Parse (dataUser);
		//si poll 1 ya presento la encuesta
		if (m == 1) {
			redirect = "View3D";
			Debug.Log ("NO PRESENTA ");
		} else {
			//si poll 0 no ha presentado la encuesta
			redirect = "Inicio_poll";
			Debug.Log ("SI PRESENTA ");
		}
	}
	
	public void Btn_go()
	{
		SceneManager.LoadScene (redirect);
	}
}
