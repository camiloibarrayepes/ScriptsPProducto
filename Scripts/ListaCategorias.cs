using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Categoria
{
	public string id_category;
	public string Nombre;
	public Sprite Imagen;
}


public class ListaCategorias : MonoBehaviour {


	public Sprite Imagen;
	public GameObject prefabCategoria;
	public Transform Contenedor;

	public static int cantCategorias;



	IEnumerator Start()
	{


		WWW itemsData = new WWW ("https://kapta.biz/pproducto/readDataCat.php");
		yield return itemsData;
		string itemsDataString = itemsData.text;
		//Debug.Log ("AQUI" + itemsDataString);
		string[] words = itemsDataString.Split (';');
		cantCategorias = words.Length - 1;



		for(int i=0; i<words.Length; i++){

			//to get id
			string[] subwords = words[i].Split(',');

			if (words[i] != "") {


				List<Categoria> Lcategories = new List<Categoria> {

					new Categoria{ id_category=subwords[0], Nombre = subwords[1], Imagen=Imagen}

				};

				foreach (var itemc in Lcategories) {
					GameObject _categoria = Instantiate (prefabCategoria, Contenedor);
					_categoria.GetComponent<Detallescategorias> ().Crear (itemc);
				}
			}
		}//

	}


}