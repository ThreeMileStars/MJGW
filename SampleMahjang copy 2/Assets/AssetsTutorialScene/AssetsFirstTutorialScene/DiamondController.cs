using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondController : MonoBehaviour {

	
	// Use this for initialization
	GameObject diamond0;
	
	void Start () {
		diamond0 = GameObject.Find("diamond0");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pointerEnterUI(){
		Debug.Log("pointed");
		iTween.MoveTo(diamond0,iTween.Hash("y",diamond0.transform.position.y+50,"time",0.5f));
	}

	public void pointerExit(){
		Debug.Log("exit");
		iTween.MoveTo(diamond0,iTween.Hash("y",diamond0.transform.position.y-50,"time",0.5f));
	}

	public void dragUI(){
		Debug.Log("dragged");
		diamond0.transform.position=Input.mousePosition;
		
	}
}
