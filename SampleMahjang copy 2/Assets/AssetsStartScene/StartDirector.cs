using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartDirector : MonoBehaviour {


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}

	public void toRuleScene(){
		SceneManager.LoadScene ("RuleTopScene");

	}

	public void toTutorialScene(){
		SceneManager.LoadScene ("TutorialScene");
	}

	public void toInformationScene(){
		SceneManager.LoadScene("InformationScene");
	}




}
