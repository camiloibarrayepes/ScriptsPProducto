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
	private string category_id;

	//para despligue de pregunta
	public Text question;

	public Image image_subc;

	//url prueba img
	public string url_img_subc = "https://www.extremetech.com/wp-content/uploads/2018/01/BMW-CarPlay-Harman-640x353.jpg";

	//url consulta url img
	string get_Category_img = "https://kapta.biz/pproducto/get_url_img_category.php";

	//url consulta url name
	string get_name = "https://kapta.biz/pproducto/get_name_category.php";

	//url para consultar preguntas a partir de id categoria
	string get_questions = "https://kapta.biz/pproducto/get_questions.php";

	//variable para recibir url
	public string geturl;

	//variable para recibir preguntas
	public string getquestion;

	//variable para recibir nombre
	public string getname;

	//variable para mantener array de preguntas
	public static List<int> questionPres = new List<int>();

	//variable para mantener id y nombre categoria
	public static string static_category_name;
	public static string static_category_id;
	public static string static_actual__id;

	//captura nombre categoria desde categorias y despligue
	public Text CatTxt;

	//variable posicion
	public static int num;

	//limite array preguntas
	public int limit;
	//array preguntas
	public string[] words;


	//variable para mantener array de preguntas
	public static List<int> arrayCategories = new List<int>();

	//variable longitud categorias
	public int cantCategorias;

	//auxiliar numero categorias
	public int auxCat;

	public static int int_static_actual__id=1;

	IEnumerator Start()
	{

		Debug.Log ("ID INICIAL/ACTUAL" + SubCategoriesList.int_static_actual__id);

		//capturo longitud categorias
		cantCategorias = ListaCategorias.cantCategorias;

		//Debug.Log ("EMPTY INICIAL" + questionPres.Count);

		WWW abc = new WWW (url_img_subc);
		yield return abc;


		//capturo id categoria
		if (SubCategoriesList.static_category_id == null) {
			//Debug.Log ("PRIMERA VEZ " + SubCategoriesList.static_category_id);
			category_id = SubCategoriesList.int_static_actual__id.ToString();

			//si es enviada desde subcategoria o desde categorias
			if (static_actual__id != null) {
				static_category_id = static_actual__id;
			} else {
				static_category_id = category_id;
			}

			GetUrlImg (category_id);
			//Debug.Log ("ENVIADO PRIMERA VEZ " + static_category_id);

		} else {
			Debug.Log ("MAS 1 VEZ " + SubCategoriesList.static_category_id);
			category_id = SubCategoriesList.int_static_actual__id.ToString();
			GetUrlImg (category_id);
		}



	}

	private void Awake()
	{

		DontDestroyOnLoad (gameObject);

	}






	/*--------------- CAPTURA IMAGEN A PARTIR DE ID CATEGORIA----------------------*/

	public void GetUrlImg(string catid)
	{
		
		WWWForm form = new WWWForm ();
		form.AddField ("idPost", catid);

		WWW getwww = new WWW (get_Category_img, form);
		WWW getwwwquestion = new WWW (get_questions, form);
		WWW getwwwName = new WWW (get_name, form);

		StartCoroutine (QuestionRequest (getwwwquestion));
		StartCoroutine (WaitForRequest (getwww, getwwwquestion));
		StartCoroutine (NameRequest (getwwwName));  

	}


	IEnumerator NameRequest(WWW getwwwname)
	{
		yield return getwwwname;
		getname = getwwwname.text;

		CatTxt.text = getname;


	}

	IEnumerator WaitForRequest(WWW getwww, WWW getwwwquestion)
	{
		yield return getwww;
		geturl = getwww.text;

		WWW www = new WWW (geturl);
		yield return www;

		yield return getwwwquestion;
		getquestion = getwwwquestion.text;
		getLongArrayQuestions (getquestion);


		Debug.Log ("NUMEROIMAGE" + num + "Y LIMITE " + limit);

		if ((num==null) || (num == 0)) {
			image_subc.sprite = null;
			num = 0;
		} else {
			image_subc.sprite = Sprite.Create (www.texture, new Rect (0, 0, www.texture.width, www.texture.height), new Vector2 (0, 0));
		}

	}

	public void getLongArrayQuestions(string getquestion)
	{
		//Encode para tildes y simbolos NOTA: no funciona aún
		byte[] bytes = Encoding.Default.GetBytes (getquestion);
		string mystring;
		mystring = Encoding.UTF7.GetString (bytes);

		//dividir las preguntas por cada ,
		words = mystring.Split (',');
		limit = words.Length-1;
	}


	/*--------------- CAPTURA PREGUNTAS A PARTIR DE ID CATEGORIA----------------------*/


	IEnumerator QuestionRequest(WWW getquestionwww)
	{
		yield return getquestionwww;
		getquestion = getquestionwww.text;
		getLongArrayQuestions (getquestion);


		if (SubCategoriesList.num == null) {
			num = 0;
			Debug.Log ("NUMERO" + num);
			question.text = words [num];
		} else {
			if (num == limit) {
				Debug.Log ("ACABO");

				int camilo = arrayCategories.Count + 1;

				if (camilo == cantCategorias) {
					Debug.Log ("GRACIAS POR RESPONDER");
					SceneManager.LoadScene ("Gracias");
				} else {
					int_static_actual__id = int_static_actual__id + 1;
					SceneManager.LoadScene("subcategories");
					Debug.Log("BART " + int_static_actual__id);
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

		string aux_actual_id = SubCategoriesList.static_actual__id;

		//Variable auxiliar para guardar ultimo id
		static_actual__id = category_id;


		if ((aux_actual_id != null) && (aux_actual_id != static_actual__id)) {
			Debug.Log ("DIFERENTE  CATEGORIA");
			int ac = Int32.Parse (static_actual__id);
			arrayCategories.Add (ac);

		} else if (aux_actual_id == null) {
			Debug.Log ("NO COMPARACION");
		} else {
			Debug.Log ("MISMA  CATEGORIA");
		}







	}

	/*-------------------- BUTTONS -------------------------*/

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


