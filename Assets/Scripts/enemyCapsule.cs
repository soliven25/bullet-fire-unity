using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class enemyCapsule : MonoBehaviour {

	// Use this for initialization
	public int damage;
	public int hp;
	
	public AudioClip destroySound;
	AudioSource audioEnemy;
	
	public float speed = 50f;
	void Start () {
		
		damage = 0;
		hp = 5;
		audioEnemy = GetComponent<AudioSource>();
		audioEnemy.clip = destroySound;
		
		GetComponent<Rigidbody>().AddForce(transform.forward*speed);
	}
	
	// Update is called once per frame
	void Update () {
		if(damage == hp){			
			audioEnemy.Play();
			Destroy(gameObject);
		}
		
		if(transform.position.z > 1)
		{
			Destroy(gameObject);	
		}	
	}	
	void OnCollisionEnter(Collision collision)
	{
		audioEnemy.Play();
		Debug.Log("Enter Collision capsule");
		damage++;
		
		transform.GetComponent<Renderer>().material.color = Color.yellow;	
		this.transform.localScale -= new Vector3(0.0f,0.3f,0.0f);
	}	
}
