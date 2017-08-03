using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAGreatWall : MonoBehaviour {

public GameObject tempGameObject,mainCamera;
public int numOfTiles;
public int[] resultSouth;
public int[] resultWest;
public int[] resultNorth;
public int[] resultEast;
int cnt = 144;
	// Use this for initialization
	void Start () {
		mainCamera=GameObject.Find("Main Camera");
		numOfTiles=36;
		resultWest= new int[numOfTiles];
		resultNorth=new int[numOfTiles];
		resultEast=new int[numOfTiles];
		resultSouth=new int[numOfTiles];

		tilesMakeAGreatWall();
		Invoke("cameraZoomOut",6);
		Invoke("cameraXRotationChange",6);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void tilesMakeAGreatWall(){
		

		//add all tiles into a list
		List<int> numbers = new List<int>(cnt);
		for(int i =1;i<=cnt;i++)
		{
			numbers.Add(i);
		}
		//make 36 randam tile for South and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			resultSouth[i]=numbers[random];
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at South
		float zPositionSouth=8f;
		float setTime=1f;
		int topBottomCounter=0;
		for(int i=0;i<resultSouth.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultSouth[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(-8f,0.3f,zPositionSouth),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(-8f,0.9f,zPositionSouth),"time",setTime,"easetype",iTween.EaseType.linear));
				zPositionSouth--;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"z",90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}

		//make 36 randam tile for West and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			//Debug.Log(random+" Random");
			resultWest[i]=numbers[random];
			//Debug.Log(numbers[random]+" List<int> numbers");
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at West
		float xPositionWest=10.5f;
		for(int i=0;i<resultWest.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultWest[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionWest,0.3f,4f),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionWest,0.9f,4f),"time",setTime,"easetype",iTween.EaseType.linear));
				xPositionWest--;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}

		//make 36 randam tile for North and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			//Debug.Log(random+" Random");
			resultNorth[i]=numbers[random];
			//Debug.Log(numbers[random]+" List<int> numbers");
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at North
		float zPositionNorth=-14.5f;
		for(int i=0;i<resultNorth.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultNorth[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(7,0.3f,zPositionNorth),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(7,0.9f,zPositionNorth),"time",setTime,"easetype",iTween.EaseType.linear));
				zPositionNorth++;;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"z",90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}

		//make 36 randam tile for East and - them from the list
		for(int i=0;i<numOfTiles;i++)
		{
			int random = Random.Range(0,cnt);
			//Debug.Log(random+" Random");
			resultEast[i]=numbers[random];
			//Debug.Log(numbers[random]+" List<int> numbers");
			cnt--;
			numbers.RemoveAt(random);
		}

		//move 36 tiles onto the board at East
		float xPositionEast=-11.5f;
		for(int i=0;i<resultEast.Length;i++)
		{
			//Debug.Log(result[i]);
			string tileName = resultEast[i].ToString();
			//Debug.Log(tileName+" OBJECT");
			tempGameObject = GameObject.Find(tileName.ToString());
			topBottomCounter++;
			if(topBottomCounter%2==1){
			iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionEast,0.3f,-10.5f),"time",setTime,"easetype",iTween.EaseType.linear));
			}else{
				iTween.MoveTo(tempGameObject,iTween.Hash("position",new Vector3(xPositionEast,0.9f,-10.5f),"time",setTime,"easetype",iTween.EaseType.linear));
				xPositionEast++;
			}
			tempGameObject.GetComponent<CubeTileAsset>().onTheBoard=true;
			iTween.RotateTo(tempGameObject,iTween.Hash("x",-90f,"time",0.1f,"looptype",iTween.LoopType.none));
			//iTween.RotateTo(tempGameObject,iTween.Hash("y",0f,"time",0.4f,"looptype",iTween.LoopType.none,"delay",delayTime));
			setTime+=0.02f;
			
		}
	}


	void cameraZoomOut(){
		iTween.ValueTo(gameObject,iTween.Hash("from",78f,"to",100f,"time",0.5f,"onupdate","setCameraViewValue"));
	}
	void setCameraViewValue(float view){
		mainCamera.GetComponent<Camera>().fieldOfView=view;
	}

	void cameraXRotationChange(){
		iTween.ValueTo(gameObject,iTween.Hash("from",50f,"to",60f,"time",0.5f,"onupdate","setCameraXRotationValue"));
	}

	void setCameraXRotationValue(float xRote){
		mainCamera.transform.eulerAngles = new Vector3(xRote,0f,0f);
	}


	public void playersGetTilesForStart(){
		
	}
}
