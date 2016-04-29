using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	public void OnClick(){
		Debug.Log("StartButton On Click");
		Application.LoadLevel("eye_practice");
	}
	
	public void OnOver(){
		Debug.Log("StartButton On Over");	
	}
	
	public void OnExit(){
		Debug.Log("StartButton On Exit");
	}
}
