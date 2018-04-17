using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
	[SerializeField]
	float speed;
	Vector3 s_pos;
	[SerializeField]
	float e_pos;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		s_pos = transform.position;
	}

	void Update () {


	}

	void FixedUpdate () {
		rb.MovePosition(new Vector3(s_pos.x - Mathf.PingPong(Time.time * speed, e_pos), s_pos.y , s_pos.z));
	}
}
