using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Release : MonoBehaviour {

	GameObject Player;
	GameObject Enemy;
	[SerializeField]
	float Speed;
	[SerializeField]
	GameObject wall;
	bool flagA;
	void Start () {
		Player = GameObject.Find ("Player");
		Enemy = GameObject.Find ("Enemy 1");
		flagA = false;
	}
		
	void Update () {
		if (Player != null) {
			if (flagA) {
				Enemy.transform.position = Vector3.MoveTowards (Enemy.transform.position, new Vector3 (Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Speed * Time.deltaTime);

				var pos = wall.transform.position;
				wall.transform.position = Vector3.Lerp (new Vector3 (pos.x, pos.y, pos.z), new Vector3 (pos.x, pos.y - 10, pos.z), Time.deltaTime);
			}
		}
	}

	void OnTriggerEnter(Collider hit){

		if (hit.gameObject.CompareTag ("Player")) {
			flagA = true;
		} 

	}

}
