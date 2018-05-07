using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using UnityEngine.SceneManagement;

public class welcomeUserScript : MonoBehaviour {

	private string user_name;
	private string user_id;
	public Text user;

	public string concesionario_elegido;


	// Use this for initialization
	void Start () {


		user_name = LoginUserSQL.var_name;
		user_id = LoginUserSQL.var_id;
		Debug.Log ("VAR NOMBRE" + user_name);
		user.text = user_name;

		Debug.Log ("ID USUARIO" + user_id);



	}
	
	// Update is called once per frame
	void Update () {


	}
}
