using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	//Declaro variable Static Value para ser enviada
	public static string Value;
	public static string CategoryValue;
	public Text Nombre;
	public Text NameCategory;
	public Text id_category;


	private void Start()
	{


	}


	private void Awake()
	{

		DontDestroyOnLoad (gameObject);

	}



	public void GoToCategories()
	{
		SceneManager.LoadScene ("Categories");
	}

	public void GoToSubCategories()
	{
		//Igualo Value al valor de Nombre, segun la categoria
		Value = id_category.GetComponent<UnityEngine.UI.Text> ().text;

		CategoryValue = NameCategory.GetComponent<UnityEngine.UI.Text> ().text;

		SceneManager.LoadScene("subcategories");
	}

	public void GotoConsesionario()
	{
		//Envio de consesionario
		Value = Nombre.GetComponent<UnityEngine.UI.Text> ().text;
		Debug.Log ("CONSESIONARIO ELEGIDO: " + Value);
		SceneManager.LoadScene("Inicio_poll");
	}



}
