using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//プレーヤーの動きを感知する
public class EnemyRay : MonoBehaviour {
	[SerializeField]
	private GameObject player;
	[SerializeField]
	public LayerMask mask;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			RaycastHit hit;
			if (Physics.BoxCast (transform.position + new Vector3 (1.3f, 4, -50), new Vector3 (100, 10, 1), transform.forward, out hit, transform.rotation )) {
				if(player.gameObject.layer == LayerMask.NameToLayer ("Player")){
					if (EnemyManager.state == 2 && PlayerManager.state == 1) {
					Debug.Log ("hit");
					}
				}
			}
			 else {
				Debug.Log ("nothit");
			}

			//			Debug.DrawRay (player.transform.position, new Vector3 (0, 0, 3), Color.red, 3.0f);
		}
	}
//		void OnDrawGizmos () {
//			Gizmos.color = new Color(1, 1, 1, 1f);
//		Gizmos.DrawCube(transform.position + new Vector3(1.3f,4,-50), new Vector3(100, 10, 100));
//		}
}
