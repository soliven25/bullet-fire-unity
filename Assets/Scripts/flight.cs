using UnityEngine;
using System.Collections;

public class flight : MonoBehaviour {

	// Use this for initialization
	public float speed;
	public GameObject bulletPrefab;
	void Start () {
		speed = 0.06F;
	}
	
	// Update is called once per frame
	void Update () {
		float leftRight = Input.GetAxis("Horizontal");
		float upDown = Input.GetAxis("Vertical");
		
		transform.Translate(Vector3.right*speed*leftRight,Space.World);
		transform.Translate(Vector3.up*speed*upDown, Space.World);
		
		if(Input.GetKeyDown("space")){
			Instantiate(bulletPrefab, transform.position, transform.rotation);
			//Debug.Log("space pressed");
		}		
		
	}
}
