using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class SubCategoriesList : MonoBehaviour {

	private string category_name;
	private int category_id;

	//para despligue de pregunta
	public Text question;

	//para despligue de opciones
	public Text options;

	//BOTONES PARA DESPLIGUE DE OPCIONES
	public Text op1;
	public Text op2;
	public Text op3;


	public Image image_subc;



	//url consulta url name
	string get_name = "https://kapta.biz/pproducto/get_name_category.php";

	//url para consultar preguntas a partir de id categoria
	string get_questions = "https://kapta.biz/pproducto/get_questions.php";

	//url consultar opciones
	string get_options = "https://kapta.biz/pproducto/get_options_question.php";


	//variable para recibir url
	public string geturl;

	//variable para recibir preguntas
	public string getquestion;

	//variable para recibir nombre
	public string getname;

	//variable para recibir opciones de la pregunta
	public string getoptions;

	//variable para mantener array de preguntas
	public static List<int> questionPres = new List<int>();

	//variable para mantener id y nombre categoria
	public static string static_category_name;
	public static int static_category_id=1;
	public static int static_actual__id;

	//captura nombre categoria desde categorias y despligue
	public Text CatTxt;

	//variable posicion
	public static int num;

	//limite array preguntas
	public int limit;
	//array preguntas
	public string[] words;

	//array opciones 1
	public string[] array_options;
	//array opciones 2
	public string[] array_suboptions;


	//variable para mantener array de preguntas
	public static List<int> arrayCategories = new List<int>();

	//variable longitud categorias
	public int cantCategorias;

	//auxiliar numero categorias
	public int auxCat;

	public static int int_static_actual__id=1;

	void Start()
	{

		Debug.Log ("ID INICIAL/ACTUAL" + SubCategoriesList.int_static_actual__id);

		//capturo longitud categorias
		cantCategorias = 5;

		//capturo id categoria
		if (static_category_id == 1) {
			//Debug.Log ("PRIMERA VEZ " + SubCategoriesList.static_category_id);
			category_id = 1;

			GetUrlImg (category_id);

		} else {
			
			category_id = SubCategoriesList.static_category_id;
			GetUrlImg (category_id);
		}



	}

	private void Awake()
	{

		DontDestroyOnLoad (gameObject);

	} 


	/*--------------- CAPTURA IMAGEN A PARTIR DE ID CATEGORIA----------------------*/

	public void GetUrlImg(int catid)
	{
		
		WWWForm form = new WWWForm ();
		form.AddField ("idPost", catid);

		WWW getwwwquestion = new WWW (get_questions, form);
		WWW getwwwName = new WWW (get_name, form);
		WWW getwwwOptions = new WWW (get_options, form);


		StartCoroutine (NameRequest (getwwwName)); 
		StartCoroutine (OptionsRequest (getwwwOptions)); 
		StartCoroutine (QuestionRequest (getwwwquestion));


	}


	IEnumerator NameRequest(WWW getwwwname)
	{
		yield return getwwwname;
		getname = getwwwname.text;
		CatTxt.text = getname;

	}


	/*--------------- CAPTURA PREGUNTAS A PARTIR DE ID CATEGORIA----------------------*/


	IEnumerator QuestionRequest(WWW getquestionwww)
	{
		yield return getquestionwww;
		getquestion = getquestionwww.text;

		words = getquestion.Split (',');
		limit = words.Length-1;


		if (num == 0) {
			question.text = words [num];
		} else {
			if (num == limit) {
				Debug.Log ("ACABO");
				int camilo = arrayCategories.Count + 1;
				Debug.Log ("ARRAYCATEGORIES " + arrayCategories.Count);

				if (camilo == cantCategorias) {
					Debug.Log ("GRACIAS POR RESPONDER");
					SceneManager.LoadScene ("Gracias");
				} else {
					static_category_id = static_category_id + 1;
					SceneManager.LoadScene("subcategories");
					Debug.Log("BART " + static_category_id);
				}

				num = 0;

			} else {
				num = SubCategoriesList.num;
				Debug.Log ("NUMERO" + num);
				question.text = words [num];
				questionPres.Add (num);
				num = num + 1;
			}

		}


		Debug.Log ("COUNT CAPTURADA" + SubCategoriesList.questionPres.Count);
		Debug.Log ("EMPTY FINAL" + questionPres.Count);


		/*------------ COMPARACION DE CATEGORIA start --------------*/

		//recibo de variable

		int aux_actual_id = SubCategoriesList.static_category_id;

		//Variable auxiliar para guardar ultimo id
		static_actual__id = category_id;


		if (aux_actual_id != static_actual__id) {
			Debug.Log ("DIFERENTE  CATEGORIA");
			arrayCategories.Add (static_category_id);

		} else {
			Debug.Log ("MISMA  CATEGORIA");
		}

	}

	/*-----------------------------------------------------------------*/


	IEnumerator OptionsRequest(WWW getwwwOptions)
	{
		yield return getwwwOptions;
		getoptions = getwwwOptions.text;
		array_options = getoptions.Split (';');

		if (num == 0) {
			num = 1;
		}

		array_suboptions = array_options[num-1].Split (',');
		op1.text = array_suboptions [0];
		op2.text = array_suboptions [1];
		op3.text = array_suboptions [2];

	}


	/*------------------------------ BUTTONS ---------------------------*/

	public void GoToSubCategories()
	{
		
		SceneManager.LoadScene("subcategories");
	}

	public void GoToCategories()
	{

		SceneManager.LoadScene("Categories");
	}


	/*-----------------------------------------------------------------------------*/

}


