using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterSQLUser : MonoBehaviour {

	public InputField inputNombre;
	public InputField inputEmail;
	public InputField inputPass;
	public GameObject message;

	public static string var_id_register;

	public Text anuncio;


	string CreateUserURL = "https://kapta.biz/pproducto/registerUser.php";

	// Use this for initialization
	void Start () {

		message.SetActive (false);
	}
	
	// Update is called once per frame

	public void BtnRegister()
	{
		
		CreateUser (inputNombre.text, inputEmail.text, inputPass.text);
		var_id_register = inputNombre.text;
	}



	public void CreateUser(string nombre, string email, string pass)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("nombrePost", nombre);
		form.AddField ("emailPost", email);
		form.AddField ("passPost", pass);

		WWW www = new WWW (CreateUserURL, form);

		StartCoroutine (WaitForRequest (www));

	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		if (www.text == "falta_nombre") {
			editMessage ("Ingresa un nombre");
		}
		if (www.text == "REGISTRO") {
			Debug.Log ("REGISTRO");
			SceneManager.LoadScene("LoginUser");
		} else {
			editMessage ("Usuario ya registrado");
		}
		Debug.Log ("LOGCAMILO" + www.text);
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
