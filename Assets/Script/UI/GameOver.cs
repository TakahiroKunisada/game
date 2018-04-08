using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
	[SerializeField]
	GameObject gameover;
	GameObject camera;
	// Use this for initialization
	void Start () {
		camera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter( Collider hit )
	{
		if (hit.gameObject.CompareTag ("Player")) {
			Destroy (hit.gameObject);
			gameover.SetActive (true);
			camera.transform.position = new Vector3 (1,1200,69); 
		}

	}

}
