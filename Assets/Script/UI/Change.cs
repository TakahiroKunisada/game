using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	[SerializeField]
	GameObject Stage1_4;
	[SerializeField]
	GameObject Stage5_8;
	[SerializeField]
	GameObject Stage9_12;
	 int s_count = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void stage_change(){
		s_count++;
		if(s_count % 3 == 1){
		Stage1_4.SetActive (false);
		Stage5_8.SetActive (true);
		Stage9_12.SetActive (false);
		}
		if(s_count % 3 == 2){
			Stage1_4.SetActive (false);
			Stage5_8.SetActive (false);
			Stage9_12.SetActive (true);
		}
		if(s_count % 3 == 0){
			Stage1_4.SetActive (true);
			Stage5_8.SetActive (false);
			Stage9_12.SetActive (false);
		}
	}

}
