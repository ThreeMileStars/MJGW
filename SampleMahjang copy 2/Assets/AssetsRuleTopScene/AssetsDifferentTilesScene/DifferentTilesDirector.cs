using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifferentTilesDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toRuleTopScene(){
		SceneManager.LoadScene("RuleTopScene");
	}

	public void toGroupTilesScene(){
		SceneManager.LoadScene("GroupTypeScene");
	}
}
