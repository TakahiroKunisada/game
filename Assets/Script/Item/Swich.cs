using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swich : MonoBehaviour {

	[SerializeField]
	GameObject wall;
	static bool flagA;
	// Use this for initialization
	void Start () {
		flagA = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (flagA) {
			var pos = wall.transform.position;
			wall.transform.position = Vector3.Lerp (new Vector3 (pos.x,pos.y,pos.z),new Vector3(pos.x,pos.y-10,pos.z),Time.deltaTime);
		}
	}

	void OnTriggerEnter(Collider hit){
		
			if (hit.gameObject.CompareTag ("Player")) {
				flagA = true;
			} 

	}

}
