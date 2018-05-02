using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnGo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Bton_from_welcomeUser_to_view3d()
	{
		SceneManager.LoadScene ("View3D");
	}

	public void Btn_welcome()
	{
		SceneManager.LoadScene ("Inicio_poll");
	}

	public void View3D()
	{
		SceneManager.LoadScene ("View3D");
	}

	public void Go_concecionario()
	{
		SceneManager.LoadScene ("ListConsesionario");
	}

	public void inicio()
	{
		SceneManager.LoadScene ("WelcomeUser");
	}

	public void go_login_user()
	{
		SceneManager.LoadScene ("LoginUser");
	}

	public void go_user_register()
	{
		SceneManager.LoadScene ("RegisterUserSQLUser");
	}

	public void go_categories()
	{
		SceneManager.LoadScene ("Categories");
	}

	public void go_sub_categories()
	{
		SceneManager.LoadScene ("subcategories");
	}

	public void go_menu()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void logout()
	{
		LoginUserSQL.var_name = "0";
		SceneManager.LoadScene ("LoginUser");
	}

	public void solicitarAsesor()
	{
		SceneManager.LoadScene ("SolicitarAsesor");
	}

}
