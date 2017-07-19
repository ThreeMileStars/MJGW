using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart0Controller : MonoBehaviour {
GameObject heart0;
	// Use this for initialization
	void Start () {
		heart0 = GameObject.Find("heart0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		public void pointerEnterUI(){
		Debug.Log("pointed");
		iTween.MoveTo(heart0,iTween.Hash("y",heart0.transform.position.y+50,"time",0.5f));
	}

	public void pointerExit(){
		Debug.Log("exit");
		iTween.MoveTo(heart0,iTween.Hash("y",heart0.transform.position.y-50,"time",0.5f));
	}

	public void dragUI(){
		Debug.Log("dragged");
		heart0.transform.position=Input.mousePosition;
		
	}
}

