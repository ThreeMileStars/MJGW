using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0, 0, 9.81f);
		transform.GetComponent< Rigidbody >().angularVelocity = new Vector3(5,5,5);
		transform.GetComponent< Rigidbody >().velocity = new Vector3(1,-1,0) * 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
