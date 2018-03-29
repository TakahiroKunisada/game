using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
	float time;
	GameObject retry;
	GameObject exit;
	GameObject player;
	// Use this for initialization
	void Start () {
		retry = GameObject.Find ("Canvas/Button");
		exit = GameObject.Find ("Canvas/Button2");
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
			time += Time.deltaTime;
		

//		if(time > 5){
//			retry.SetActive (true);
//			exit.SetActive (true);
//		}
	}
}
