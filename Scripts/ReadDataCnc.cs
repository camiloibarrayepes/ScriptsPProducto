using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ReadDataCnc : MonoBehaviour {

	IEnumerator Start()
	{
		WWW itemsData = new WWW ("https://kapta.biz/pproducto/readDataCat.php");
		yield return itemsData;
		string itemsDataString = itemsData.text;
		//Debug.Log ("AQUI" + itemsDataString);
		string[] words = itemsDataString.Split (',');

		foreach (string word in words) {
			Debug.Log (word);
		}
	}



}