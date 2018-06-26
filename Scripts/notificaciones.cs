using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.SimpleAndroidNotifications
{
	public class notificaciones : MonoBehaviour {

		public static string cantidad;
		public string auxcantidad_antes;
		public string auxcantidad_despues;

		string CreateUserURL = "https://kapta.biz/pproducto/prueba123.php";

		void Start()
		{
			InvokeRepeating("crear", 1f, 1f);

		}

		public void crear ()
		{
			Debug.Log("ID ASESOR " + LoginAsesorSQL.asesor_var_id);
			Debug.Log ("ID CONCESIONARIO " + LoginAsesorSQL.asesor_var_id_c);
			WWWForm form = new WWWForm ();
			form.AddField ("idConcesionario", LoginAsesorSQL.asesor_var_id_c);
			WWW www = new WWW (CreateUserURL, form);
			StartCoroutine (requestw (www));
			//Debug.Log ("CANTIDAD " + cantidad);
			//Debug.Log ("AUX " + auxcantidad);
		}

		IEnumerator requestw(WWW www)
		{
			yield return www;
			Debug.Log ("CANTIDAD ANTERIOR " + cantidad);
			auxcantidad_antes = cantidad;
			//Debug.Log ("WWW " + www.text);
			cantidad = www.text;
			auxcantidad_despues = cantidad;
			//NOTA parsear y comparar
			if ((auxcantidad_antes!=null) && (auxcantidad_despues != auxcantidad_antes)) {
				SendNotif ();
			}
			Debug.Log ("CANTIDAD DESPUES " + cantidad);
		}



		// Update is called once per frame
		public void SendNotif () 
		{
			Debug.Log ("enviar not");
			NotificationManager.SendWithAppIcon(TimeSpan.FromSeconds(5),
				"Notification", 
				"Esta es una notificacion", 
				Color.white,
				NotificationIcon.Star
			);
		}
	}
}
