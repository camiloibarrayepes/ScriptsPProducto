using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginAsesorSQL : MonoBehaviour {

	public Text user;

	// Use this for initialization
	void Start () {

		if (RegisterSQLAsesor.nombre_registrado != null) {
			user.text = "Email registrado : " + RegisterSQLAsesor.nombre_registrado;
		} else {
			user.text = "";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
