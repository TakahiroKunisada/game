using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//アイテム
//プレイヤーの移動が反転する
public class Reversal : MonoBehaviour {
	[SerializeField]
	private float time;
	[SerializeField]
	private float r_time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		time += Time.deltaTime;
		if (time > r_time) {
			PlayerMove.speed = 0.15f;
		} 


	}

	void OnTriggerEnter(Collider hit){
		if(hit.gameObject.CompareTag("Item")){
			PlayerMove.speed = -0.15f;
			time = 0;
			Destroy (hit.gameObject);
		}

	}

}
