using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSearch : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision hit){

		if (hit.gameObject.CompareTag("Player") && PlayerManager.state == 1 && EnemyManager.state == 2) {
			Destroy (hit.gameObject);
		}

	}

}
