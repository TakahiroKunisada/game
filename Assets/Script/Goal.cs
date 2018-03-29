using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	[SerializeField]
	string scene = "";
	int point;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		point = Point.count;
	}

	void OnCollisionEnter(Collision hit){
		if(hit.gameObject.CompareTag("Player")){
			SceneManager.LoadScene (scene);
			PlayerPrefs.SetInt ("SCORE",point);
		}

	}

}
