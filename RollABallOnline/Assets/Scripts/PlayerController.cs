using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody player;


	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		float moveHoriz = Input.GetAxis("Horizontal");
		float moveVer = Input.GetAxis("Vertical");
		Vector3 move = new Vector3(moveHoriz, 0, moveVer);
		player.AddForce(move);
	}
}
