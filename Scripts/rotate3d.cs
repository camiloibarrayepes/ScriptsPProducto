using UnityEngine;
using System.Collections;

public class rotate3d : MonoBehaviour {


	public GameObject  objectRotate;

	public float	   rotateSpeed = 50f;
	bool			   rotateStatus = false;
	int 			   AuxTime = 0;
	int				   use = 0;

	public GameObject  btnRight;
	public GameObject  btnLeft;
	public GameObject  btnStop;

	public void Right() {

		if (rotateStatus==false){
			AuxTime = 1;
			rotateStatus = true;
			btnLeft.SetActive (false);
			btnRight.SetActive (false);
		}
		else{
			rotateStatus = false;
			btnLeft.SetActive (true);
			btnRight.SetActive (true);
		}
	}

	public void Left() {

		if (rotateStatus==false){
			AuxTime = -1;
			rotateStatus = true;
			btnLeft.SetActive (false);
			btnRight.SetActive (false);
		}
		else{
			rotateStatus = false;
			btnLeft.SetActive (true);
			btnRight.SetActive (true);
		}
	}

	public void Stop(){
		rotateStatus = false;
		btnLeft.SetActive (true);
		btnRight.SetActive (true);
	}

	void Update(){
		if (rotateStatus == true) {
			objectRotate.transform.Rotate (Vector3.up, rotateSpeed * AuxTime*Time.deltaTime);
		}
	}



}
