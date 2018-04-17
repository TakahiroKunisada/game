using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	[SerializeField]
	GameObject Stage1_4;
	[SerializeField]
	GameObject Stage5_8;
	int count = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void stage_change(){
		count++;
		if(count % 2 == 1){
		Stage1_4.SetActive (false);
		Stage5_8.SetActive (true);
		}
		if(count % 2 == 0){
			Stage1_4.SetActive (true);
			Stage5_8.SetActive (false);
		}
	}

}
