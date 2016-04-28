using UnityEngine;
using System.Collections;

public class enemyCapsule : MonoBehaviour {

	// Use this for initialization
	public int damage;
	public int hp;
	void Start () {
		
		damage = 0;
		hp = 5;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(damage == hp)
			Destroy(gameObject);
	
	}
	void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
		Debug.Log("enemy Colider");
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Enter Collision capsule");
		
	}
	
}
