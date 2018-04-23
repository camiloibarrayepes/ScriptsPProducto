using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterSQLAsesor : MonoBehaviour {

	public InputField inputNombre;
	public InputField inputCedula;
	public InputField inputPass;
	public InputField inputCodigo;
	public GameObject message;

	public Text anuncio;


	string CreateUserURL = "https://kapta.biz/pproducto/register.php";

	//User const

	private const string username = "";
	private const string password = "";

	// Use this for initialization
	void Start () {

		message.SetActive (false);
	}
	
	// Update is called once per frame

	public void BtnRegister()
	{
		
		CreateUser (inputNombre.text, inputCedula.text, inputPass.text, inputCodigo.text);
	}



	public void CreateUser(string nombre, string cedula, string pass, string codigo)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("nombrePost", nombre);
		form.AddField ("cedulaPost", cedula);
		form.AddField ("passPost", pass);
		form.AddField ("codigoPost", codigo);

		WWW www = new WWW (CreateUserURL, form);

		StartCoroutine (WaitForRequest (www));

	}

	IEnumerator WaitForRequest(WWW www)
	{
		
		yield return www;

		string switchVar = www.text;

		switch (switchVar)
		{

		case "falta_nombre":
			Debug.Log ("NOMBRE");
			editMessage ("Ingresa un nombre");
			break;
		case "falta_cedula":
			Debug.Log ("CEDULA");
			editMessage ("Ingresa cédula");
			break;
		case "falta_codigo":
			Debug.Log ("CODIGO");
			editMessage ("Ingresa un código");
			break;
		case "falta_pass":
			Debug.Log ("PASSWORD");
			editMessage ("Ingresa un password");
			break;
		case "cedula_no_int":
			Debug.Log ("CEDULA NO INT");
			editMessage ("Solo números en cedula");
			break;
		default:
			Debug.Log ("DEFAULT");
			break;

		}


		if (www.text == "REGISTRO") {
			Debug.Log ("GO INICIO");
			SceneManager.LoadScene("WelcomeUser");
		} else if(www.text == "NO"){
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
