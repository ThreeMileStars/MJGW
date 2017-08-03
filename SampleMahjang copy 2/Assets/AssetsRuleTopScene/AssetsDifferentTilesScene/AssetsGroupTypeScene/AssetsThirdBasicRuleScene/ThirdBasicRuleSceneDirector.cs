using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdBasicRuleSceneDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
	public void backScene(){
		
		SceneManager.LoadScene("GroupTypeScene");
        
    }
}
