using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterSQLAsesor : MonoBehaviour {

	public InputField inputNombre;
	public InputField inputEmail;
	public InputField inputPass;
	public InputField inputCodigo;
	public GameObject message;

	public static string nombre_registrado;

	public static string var_id_register;

	public Text anuncio;


	string CreateUserURL = "https://kapta.biz/pproducto/register.php";

	// Use this for initialization
	void Start () {

		message.SetActive (false);
	}

	// Update is called once per frame

	public void BtnRegister()
	{

		CreateUserAsesor (inputNombre.text, inputEmail.text, inputPass.text, inputCodigo.text);
		var_id_register = inputNombre.text;
		nombre_registrado = inputEmail.text;
	}



	public void CreateUserAsesor(string nombre, string email, string pass, string codigo)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("nombrePost", nombre);
		form.AddField ("emailPost", email);
		form.AddField ("passPost", pass);
		form.AddField ("codigoPost", codigo);


		WWW www = new WWW (CreateUserURL, form);

		StartCoroutine (WaitForRequest (www));

	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		if (www.text == "NOMBRE") {
			editMessage ("Ingresa un nombre");
		} else if (www.text == "EMAIL") {
			editMessage ("Ingresa un email");
		} else if (www.text == "PASS") {
			editMessage ("Ingresa una contraseña");
		} else if (www.text == "CODIGOFALTA") {
			editMessage ("Ingresa un codigo");
		} else if (www.text == "REGISTRO") {
			Debug.Log ("REGISTRO");
			SceneManager.LoadScene ("login");
		} else if (www.text == "NO") {
			editMessage ("Usuario ya registrado");
		} else if (www.text == "CODIGO") {
			editMessage ("Código no válido");
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
