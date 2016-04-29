using UnityEngine;
using System.Collections;

public class GameFlow : MonoBehaviour {

	// Use this for initialization
	public void OnClick(){
		Debug.Log("GameFlow On Click");
		Application.LoadLevel("UI");
	}
	
	public void OnOver(){
		Debug.Log("GameFlow On Over");	
	}
	
	public void OnExit(){
		Debug.Log("GameFlow On Exit");
	}
}
