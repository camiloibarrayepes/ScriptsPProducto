using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;

public class DetallesPregunta : MonoBehaviour {

	public string id_question_value;
	public string option_value;

	public Text id_question;
	public Text id_opcion;
	public Text question;

	public static int static_id_question_value;
	public static string static_option_value;


	//para captura de user id
	public string userid;

	//url insert data
	string insert_data = "https://kapta.biz/pproducto/insert_data_question.php";

	//variable para recibir nombre
	private string getinsertdata;

	private string dataInsert;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CrearPregunta(Pregunta pregunta)
	{
		id_question.text = pregunta.id_question.ToString();
		id_opcion.text = pregunta.option;
		question.text = pregunta.question;
	}


	public void GoToSubCategories()
	{
		//Igualo Value al valor de Nombre, segun la categoria
		id_question_value = id_question.GetComponent<UnityEngine.UI.Text> ().text;
		option_value =  question.GetComponent<UnityEngine.UI.Text> ().text;
		Debug.Log ("IDQUI " + id_question_value);
		Debug.Log ("QUESTIONQUI " + option_value);
		SceneManager.LoadScene("subcategories");
		Debug.Log ("USER ID CAPTURADO " + LoginUserSQL.var_id);
		Create (option_value);




	}

	public void Create(string option)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("optionPost", option_value);
		form.AddField ("idUserPost", LoginUserSQL.var_id);
		form.AddField ("idQuestionPost", id_question_value);
		WWW www = new WWW (insert_data, form);
	}

				
			




}
