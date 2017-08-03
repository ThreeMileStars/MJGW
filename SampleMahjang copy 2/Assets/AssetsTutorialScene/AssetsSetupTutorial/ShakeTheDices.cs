using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTheDices : MonoBehaviour {

	GameObject d1,d2,directionalLight,spotLight;
	// Use this for initialization
	void Start () {
		d1=GameObject.Find("Dice1");
		d2=GameObject.Find("Dice2");
		directionalLight=GameObject.Find("Directional Light");
		spotLight=GameObject.Find("Spotlight");
		Invoke("startDices",4f);
		Invoke("controlLights",4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startDices(){
		d1.GetComponent<Rigidbody>().useGravity=true;
		d1.transform.GetComponent< Rigidbody >().angularVelocity = new Vector3(5,5,5);
		d1.transform.GetComponent< Rigidbody >().velocity = new Vector3(2,0,0);

		d2.GetComponent<Rigidbody>().useGravity=true;
		d2.transform.GetComponent< Rigidbody >().angularVelocity = new Vector3(3,4,-2);
		d2.transform.GetComponent< Rigidbody >().velocity = new Vector3(-5,0,-4);
	}

	public void controlLights(){
		directionalLight.GetComponent<Light>().intensity=0.5f;
		spotLight.GetComponent<Light>().enabled=true;
	}
}
