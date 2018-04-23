using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetallesCons : MonoBehaviour {

	public Text Nombre;
	public Image Imagen;
	public Button button;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void Crear(Consesionarios consesionario) {
		Nombre.text = consesionario.Nombre;
		Imagen.sprite = consesionario.Imagen;
	}
}
