using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEngine.SceneManagement;


public class startPoll : MonoBehaviour {

	string urlPoll = "https://kapta.biz/pproducto/insert_data_poll.php";

	private string dataUser;

	public string redirect;

	public int iduserget;

	// Use this for initialization
	void Start () {

		Debug.Log ("USER ID " + LoginUserSQL.var_id);

	}

	public void CreatePoll()
	{
		WWWForm form = new WWWForm ();
		iduserget = Int32.Parse (LoginUserSQL.var_id);
		//envio el id de usuario y me devuelve el campo poll 1 o 0
		form.AddField ("idUserPost", iduserget);
		WWW wwwstate = new WWW (urlPoll, form);

		StartCoroutine (request (wwwstate));
	}

	IEnumerator request(WWW wwwstate)
	{
		yield return wwwstate;
		dataUser = wwwstate.text;
		Debug.Log ("INSERT POLL " + dataUser);
		//int m = Int32.Parse (dataUser);

	}

	public void Btn_go()
	{
		SceneManager.LoadScene ("subcategories");
	}


}
