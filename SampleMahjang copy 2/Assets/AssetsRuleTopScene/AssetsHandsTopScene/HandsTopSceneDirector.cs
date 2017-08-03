using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandsTopSceneDirector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toStartScene(){
		SceneManager.LoadScene ("StartScene");
	}

	public void toChickenScene(){
		SceneManager.LoadScene("ChickenScene");
	}

	public void toOneGroupScene(){
		SceneManager.LoadScene("OneGroupScene");
	}

	public void toFlushScene(){
		SceneManager.LoadScene("FlushScene");
	}

	public void toCORNERSScene(){
		SceneManager.LoadScene("CORNERSScene");
	}

	public void toISLANDScene(){
		SceneManager.LoadScene("ISLANDScene");
	}

	public void toACTIVE_DRAGON(){
		SceneManager.LoadScene("ACTION_DRAGONScene");
	}
}
