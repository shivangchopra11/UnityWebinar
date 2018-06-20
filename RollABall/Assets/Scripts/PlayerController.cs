using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Rigidbody player;
	public float speed;
	public Text countText;
	public Text winText;

	private int count;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody>();
		count = 0;
		countText.text = "Score:- 0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// FixedUpdate is called before any Physics Calculations
	void FixedUpdate() {
		float moveHoriz = Input.GetAxis("Horizontal");
		float moveVer = Input.GetAxis("Vertical");
		Vector3 move = new Vector3(moveHoriz,0f,moveVer) * speed;
		player.AddForce(move);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("pickup")) {
			other.gameObject.SetActive(false);
			count+=10;
			countText.text = "Score:- "+ count.ToString();
			if(count>=80) {
				winText.gameObject.SetActive(true);
			}
		}
	}

	public void Reset() {
		Application.LoadLevel(Application.loadedLevel);
	}
}
