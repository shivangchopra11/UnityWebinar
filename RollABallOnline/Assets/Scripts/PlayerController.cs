using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody player;
	public float speed;


	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		// float moveHoriz = Input.GetAxis("Horizontal");
		// float moveVer = Input.GetAxis("Vertical");
		float moveHoriz = Input.acceleration.x;
		float moveVer = Input.acceleration.y;
		Vector3 move = new Vector3(moveHoriz, 0, moveVer)*speed;
		player.AddForce(move);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("pickup")) {
			other.gameObject.SetActive(false);
		}	
	}
}
