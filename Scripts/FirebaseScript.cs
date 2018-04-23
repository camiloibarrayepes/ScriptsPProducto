using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;

public class FirebaseScript : MonoBehaviour {

	// Use this for initialization

	public InputField EmailAddres, Password;

	public void LoginButtonPressed()
	{
		FirebaseAuth.DefaultInstance.SignInWithEmailAndPasswordAsync(EmailAddres.text, Password.text).ContinueWith((obj)=>
		{
			Debug.Log("LOGGEADO");
			//SceneManager.LoadSceneAsync("");
			});
	}

	public void LoginAnonymousButtonPressed()
	{
		FirebaseAuth.DefaultInstance.SignInAnonymouslyAsync().ContinueWith((obj) =>
			{
				Debug.Log("LOGGEADO ANONIMO");
				//SceneManager.LoadSceneAsync("");
			});
	}

	public void CreateNewUserButtonPressed()
	{
		FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(EmailAddres.text, Password.text).ContinueWith((obj) =>
			{
				Debug.Log("CREADO");
				//SceneManager.LoadSceneAsync("");
			});

	}
}
