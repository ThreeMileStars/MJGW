using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroupTypeSceneDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toBackScene(){
		SceneManager.LoadScene("DifferentTilesScene");
	}

	public void toThirdBasicRuleScene(){
		SceneManager.LoadScene("ThirdBasicRuleScene");
	}
}
