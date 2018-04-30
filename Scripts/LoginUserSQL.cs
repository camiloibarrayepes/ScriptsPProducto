﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginUserSQL : MonoBehaviour {


	public InputField inputEmail;
	public InputField inputPass;

	public GameObject message;

	public Text anuncio;

	private string userLogin;


	//variables de usuario
	private string var_access;
	public static string var_id;
	public static string var_name;
	public static string var_email;

	string CreateUserURL = "https://kapta.biz/pproducto/loginUser.php";

	// Use this for initialization
	void Start () {

		message.SetActive (false);
	}

	private void Awake()
	{

		DontDestroyOnLoad (gameObject);

	}

	// Update is called once per frame

	public void BtnRegister()
	{

		CreateUser (inputEmail.text, inputPass.text);
	}

	public void CreateUser(string email, string pass)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("emailPost", email);
		form.AddField ("passPost", pass);

		WWW www = new WWW (CreateUserURL, form);

		StartCoroutine (WaitForRequest (www));

	}

	IEnumerator WaitForRequest(WWW www)
	{

		yield return www;

		userLogin = www.text;

		if (userLogin == "falta_email") {
			editMessage ("Ingresa un email");
		} else if (userLogin == "falta_pass") {
			editMessage ("Ingresa contraseña");
		} else if (userLogin == "denegado") {
			editMessage ("Datos incorrectos");
		} else {
			string[] credentials = userLogin.Split (',');

			var_access = credentials [1];
			var_id = credentials [2];
			var_name = credentials [3];
			var_email = credentials [4];

			if (var_access == "acceso") {
				Debug.Log ("INGRESO CORRECTO");
				SceneManager.LoadScene("ListConsesionario");
			}

			Debug.Log ("ACESS " + var_access);
			Debug.Log ("ID " + var_id); 
			Debug.Log ("NAME " + var_name);
			Debug.Log ("EMAIL " + var_email);
		}



	}

	public void editMessage(string mess)
	{
		anuncio.text = mess;
		ShowMessage ();
	}

	public void ShowMessage()
	{
		message.SetActive (true);
		HideMessage ();
	}

	public void HideMessage()
	{
		StartCoroutine (RemoveAfterSeconds (3));
	}


	IEnumerator RemoveAfterSeconds (int seconds)
	{
		yield return new WaitForSeconds (seconds);
		message.SetActive (false);
	}


}
