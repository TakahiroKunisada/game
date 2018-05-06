using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updown : MonoBehaviour {
	[SerializeField]
	GameObject floor;
	[SerializeField]
	float speed;
	Vector3 s_pos;
	[SerializeField]
	float e_pos;
	private Rigidbody rb;
	bool flagA;

	void Start () {
		flagA = false;
		rb = floor.GetComponent<Rigidbody>();
		s_pos = floor.transform.position;
	}

	void Update () {


	}

	void FixedUpdate () {
		if(flagA){
			rb.MovePosition(new Vector3(s_pos.x, s_pos.y , s_pos.z - Mathf.PingPong(Time.time * speed, e_pos)));
		}
	}

	void OnTriggerEnter(Collider hit){

		if (hit.gameObject.CompareTag ("Player")) {
			flagA = true;
		} 

	}

}
