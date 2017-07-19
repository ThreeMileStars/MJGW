using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toStartScene(){
		SceneManager.LoadScene ("StartScene");

	}

	public void toFirstTutorialScene(){
		SceneManager.LoadScene ("FirstTutorialScene");
	}

	public void toSecondTutorialScene(){
		SceneManager.LoadScene("SecondTutorialScene");
	}
}
