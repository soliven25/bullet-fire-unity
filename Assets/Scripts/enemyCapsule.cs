using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class enemyCapsule : MonoBehaviour {

	// Use this for initialization
	public int damage;
	public int hp;
	
	public AudioClip destroySound;
	AudioSource audioEnemy;
	void Start () {
		
		damage = 0;
		hp = 5;
		audioEnemy = GetComponent<AudioSource>();
		audioEnemy.clip = destroySound;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(damage == hp){
			
			
			audioEnemy.Play();
			Destroy(gameObject);
		}
	
	}	
	void OnCollisionEnter(Collision collision)
	{
		audioEnemy.Play();
		Debug.Log("Enter Collision capsule");
		damage++;
		
	}
	
}
