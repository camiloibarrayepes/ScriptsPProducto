using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Consesionarios
{
	public string Nombre;
	public Sprite Imagen;


}


public class ListCons : MonoBehaviour {

	public Sprite aux;
	public Sprite Imagen;
	public Sprite Imagen2;
	public Sprite Imagen3;



	public static string var_cons; 

	public GameObject PrefabCons;
	public Transform Contenedor;



	IEnumerator Start()
	{
		WWW itemsData = new WWW ("https://kapta.biz/pproducto/readDataCnc.php");
		yield return itemsData;
		string itemsDataString = itemsData.text;
		//Debug.Log ("AQUI" + itemsDataString);
		string[] words = itemsDataString.Split (',');


		for(int i=0; i<words.Length; i++){


			
			if (words[i] != "") {

				if (i % 2 == 0) {
					aux = Imagen2;
				} else if (i % 3 == 0) {
					aux = Imagen3;
				} else {
					aux = Imagen;
				}

				List<Consesionarios> Lcons = new List<Consesionarios> {
				
					new Consesionarios{ Nombre = words[i], Imagen=aux }


				};
			
				foreach (var itemc in Lcons) {
					GameObject _consesionario = Instantiate (PrefabCons, Contenedor);
					_consesionario.GetComponent<DetallesCons> ().Crear (itemc);
				}
			}
		}//


	}

	public void btn_go_cons(){

		Debug.Log ("CLICK");
		//SceneManager.LoadScene ("WelcomeUser");
	}





}