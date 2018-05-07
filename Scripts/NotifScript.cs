using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.SimpleAndroidNotifications
{
	public class NotifScript : MonoBehaviour {

		public void SendNotif () 
		{
			NotificationManager.Send (TimeSpan.FromSeconds(5), 
				"Notification", 
				"Esta es una notificacion", 
				Color.white);
		}
	}
}
