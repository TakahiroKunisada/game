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
	float speed;
	GameObject player;
	PlayerMove pm;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		pm = player.GetComponent<PlayerMove>();
	}
	
	// Update is called once per frame
	void Update () {
		
		time += Time.deltaTime;
		if (time > r_time) {
			pm.speed = 0.15f;
		} 


	}

	void OnTriggerEnter(Collider hit){
		if(hit.gameObject.CompareTag("Item")){
			pm.speed = -0.15f;
			time = 0;
			Destroy (hit.gameObject);
		}

	}

}
