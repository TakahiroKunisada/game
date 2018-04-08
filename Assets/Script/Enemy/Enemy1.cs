using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {
	[SerializeField]
	[Tooltip("回転の向き")]
	float direction;
	[SerializeField]
	[Tooltip("回転速度")]
	float speed;
	private float time;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime * speed;


		transform.eulerAngles = new Vector3(0, time * direction, 0);


	}
}
