using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class flight : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public GameObject bulletPrefab;
	
	public AudioClip fireSound;
	AudioSource audioFlight;
	void Start () {
		speed = 0.06F;
		audioFlight = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		float leftRight = Input.GetAxis("Horizontal");
		float upDown = Input.GetAxis("Vertical");
		
		transform.Translate(Vector3.right*speed*leftRight,Space.World);
		transform.Translate(Vector3.up*speed*upDown, Space.World);
		
		if(Input.GetKeyDown("space")){
			audioFlight.clip = fireSound;
			audioFlight.Play();
			Instantiate(bulletPrefab, transform.position, transform.rotation);
			//Debug.Log("space pressed");
		}		
		
	}
}
