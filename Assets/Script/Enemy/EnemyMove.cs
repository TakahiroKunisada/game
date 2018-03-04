using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//敵の行動パターン（詠唱時間など）　
public class EnemyMove : MonoBehaviour {
	[SerializeField]			//詠唱時間
	private float pattern_a;	//
	[SerializeField]			//
	private float pattern_b;	//
	[SerializeField]			//
	private float pattern_c;	//

	[SerializeField]			//詠唱再開までの時間(カウントダウン)
	private float look_time;	//
	[SerializeField]			//詠唱再開までの時間(基準値)
	private float l_time;		//

	[SerializeField]			//詠唱時間
	private float not_look_time;//
	private int random_number;  //パターンわけの数字
	// Use this for initialization
	void Start () {
		random_number = Random.Range (0, 101);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (random_number);
		if(random_number %3 == 0){
			Debug.Log ("パターンA");
			EnemyManager.state = 1;
			not_look_time += Time.deltaTime;
			if(pattern_a < not_look_time){
				EnemyManager.state = 2;
			}
		}

		if(random_number %3 == 1){
			Debug.Log ("パターンB");
			EnemyManager.state = 1;
			not_look_time += Time.deltaTime;
			if(pattern_b < not_look_time){
				EnemyManager.state = 2;
			}
		}

		if(random_number %3 == 2){
			Debug.Log ("パターンC");
			EnemyManager.state = 1;
			not_look_time += Time.deltaTime;
			if(pattern_c < not_look_time){
				EnemyManager.state = 2;
			}
		}

		if(EnemyManager.state == 2){
			Look ();
		}
			

	}

	void Look(){
		look_time += Time.deltaTime;
		if(look_time > l_time){
			EnemyManager.state = 1;
			look_time = 0;
			not_look_time = 0;
			random_number = Random.Range (0, 101);
		}
	}
}
