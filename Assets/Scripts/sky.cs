using UnityEngine;
using System.Collections;

public class sky : MonoBehaviour {

	// Use this for initialization
	
	void Start () {
		SpriteRenderer spr = GetComponent<SpriteRenderer>();
		Color color = spr.color;
		color.a = 0.7f;
		spr.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
