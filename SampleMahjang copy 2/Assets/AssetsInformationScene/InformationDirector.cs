using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InformationDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toStartScene(){
		SceneManager.LoadScene("StartScene");
	}

	public void toLink(){
		Application.OpenURL("https://www.amazon.com/GREAT-WALL-international-mahjong-culture/dp/146368830X");
	}
}
