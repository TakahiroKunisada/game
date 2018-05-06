using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compliance : MonoBehaviour {

	GameObject Player;
//	GameObject homingObj;
	[SerializeField]
	float Speed;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
//		homingObj = GameObject.Find ("Enemy");
	}

	// Update is called once per frame
	void Update () {
		if (Player != null) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Speed * Time.deltaTime);
		}
	}
}
