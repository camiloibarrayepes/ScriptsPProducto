using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;


public class Pregunta
{
	public int id_question;
	public string option;
	public string question;
}


public class SubCategoriesList : MonoBehaviour {

	private string category_name;
	private int category_id;
	public GameObject prefabPregunta;
	public Transform contenedorPregunta;

	//para despligue de pregunta
	public Text question;

	//para despligue de opciones
	public Text options;

	//BOTONES PARA DESPLIGUE DE OPCIONES
	public Text op1;
	public Text op2;
	public Text op3;

	//buttons
	public Button op1Button;
	public Button op2Button;
	public Button op3Button;

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
	public static int num=0;

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
		Debug.Log("ID USUARIO " + LoginUserSQL.var_id);

		Debug.Log ("ID INICIAL/ACTUAL" + SubCategoriesList.int_static_actual__id);

		//capturo longitud categorias
		cantCategorias = 5;

		//capturo id categoria
		if (static_category_id == 1) {
			category_id = 1;
		} else {
			category_id = SubCategoriesList.static_category_id;
		}

		GetAction (category_id);


	}

	private void Awake()
	{
		DontDestroyOnLoad (gameObject);
	} 




	public void GetAction(int catid)
	{

		WWWForm form = new WWWForm ();
		form.AddField ("idPost", catid);

		WWW getwwwquestion = new WWW (get_questions, form);
		WWW getwwwName = new WWW (get_name, form);
		WWW getwwwOptions = new WWW (get_options, form);



		StartCoroutine (QuestionRequest (getwwwquestion, getwwwOptions, getwwwName));
	}




	/*--------------- CAPTURA PREGUNTAS A PARTIR DE ID CATEGORIA----------------------*/


	IEnumerator QuestionRequest(WWW getquestionwww, WWW getwwwOptions, WWW getwwwname)
	{

		//Name
		yield return getwwwname;
		getname = getwwwname.text;
		CatTxt.text = getname;

		//Question
		yield return getquestionwww;
		getquestion = getquestionwww.text;

		//Options
		yield return getwwwOptions;
		getoptions = getwwwOptions.text;
		array_options = getoptions.Split (';');

		//array_suboptions = array_options[num].Split (',');
		//Debug.Log ("ARRAY OPTION NUM " + num);


		/*op1.text = array_suboptions [0];
		op2.text = array_suboptions [1];
		op3.text = array_suboptions [2];*/


		words = getquestion.Split (',');
		limit = words.Length-1;

		Debug.Log ("NUM " + num);
		if (num == 0) {
			Debug.Log ("ENTRA 1");
			question.text = words [num];
			array_suboptions = array_options[num].Split (',');
			int m = Int32.Parse (array_suboptions [0]);


			/*----------------------------------------*/

			Debug.Log ("DEBULOG " + array_suboptions.Length);
			Debug.Log("LAPICERO " + array_suboptions [3]);

			for (int i = 1; i < array_suboptions.Length; i++) {
				
					List<Pregunta> LPregunta = new List<Pregunta> {
						new Pregunta{ question = array_suboptions [i], id_question = Int32.Parse (array_suboptions [0]) }
					};
				
				if ((array_suboptions [i])!="") {
					foreach (var itemP in LPregunta) {
						GameObject _pregunta = Instantiate (prefabPregunta, contenedorPregunta);
						_pregunta.GetComponent<DetallesPregunta> ().CrearPregunta (itemP);
					}
				}

			}
			/*----------------------------------------*/



			Debug.Log("ID PREGUNTA" + array_suboptions [0]);

			num = num + 1;
		} else {
			Debug.Log ("ENTRA 2");
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

				Debug.Log ("NUMERO CAMILO" + num);
				question.text = words [num];
				array_suboptions = array_options[num].Split (',');
				int m = Int32.Parse (array_suboptions [0]);

				/*----------------------------------------*/

				Debug.Log ("DEBULOG " + array_suboptions.Length);

				for (int i = 1; i < array_suboptions.Length; i++) {
					
						List<Pregunta> LPregunta = new List<Pregunta> {
							new Pregunta{ question = array_suboptions [i], id_question = Int32.Parse (array_suboptions [0]) }
						};
					
					if ((array_suboptions [i])!="") {
						foreach (var itemP in LPregunta) {
							GameObject _pregunta = Instantiate (prefabPregunta, contenedorPregunta);
							_pregunta.GetComponent<DetallesPregunta> ().CrearPregunta (itemP);
						}
					}

				}
				/*----------------------------------------*/

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


