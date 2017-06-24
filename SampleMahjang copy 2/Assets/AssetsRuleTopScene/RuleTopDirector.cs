using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleTopDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toDifferentTilesScene(){
		SceneManager.LoadScene("DifferentTilesScene");
	}

	public void toHandsTopScene(){
		SceneManager.LoadScene("HandsTopScene");
	}

	public void toStartScene(){
		SceneManager.LoadScene("StartScene");
	}
}
