using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour {

	int score;
	GameObject star;
	GameObject star2;
	GameObject star3;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("SCORE",1);
		star = GameObject.Find("Canvas/Star/Star");
		star2 = GameObject.Find("Canvas/Star2/Star2");
		star3 = GameObject.Find("Canvas/Star3/Star3");
	}
	
	// Update is called once per frame
	void Update () {
		if (score == 1) {
			star.SetActive (true);
		}
		if (score == 2) {
			star.SetActive (true);
			star2.SetActive (true);
		}
		if (score == 3) {
			star.SetActive (true);
			star2.SetActive (true);
			star3.SetActive (true);
		}
	}
}
