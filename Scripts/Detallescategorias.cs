using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detallescategorias : MonoBehaviour {

	public Text Nombre;
	public Image Imagen;
	public Button button;
	public Text id_category;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void Crear(Categoria categoria) {

		id_category.text = categoria.id_category;
		Nombre.text = categoria.Nombre;
		Imagen.sprite = categoria.Imagen;
	}
}
