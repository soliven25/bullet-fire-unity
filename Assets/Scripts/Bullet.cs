﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public int damage = 20;
	public float speed = 1000f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce(transform.forward*speed);
		transform.GetComponent<Renderer>().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position.z > 0)
		{
			Destroy(gameObject);	
		}
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		
	    Debug.Log("name " + other.gameObject.name);
		other.gameObject.damage++;
		//Destroy(other.gameObject);
		//Destroy(gameObject);  // to destroy bullet
		Debug.Log("bullet Collider");
		
	}
}
