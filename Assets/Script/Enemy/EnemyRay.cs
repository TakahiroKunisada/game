using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//プレーヤーの動きを感知する
public class EnemyRay : MonoBehaviour {
	GameObject player;
	[SerializeField]
	public LayerMask mask;
	bool isHit;
	void Start () {
		player = GameObject.Find ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			RaycastHit hit;
			var scale = transform.lossyScale.x * 10f;

			var isHit = Physics.BoxCast (transform.position, Vector3.one * scale, transform.forward, out hit, transform.rotation);
//			if (Physics.BoxCast (transform.position + new Vector3 (1.3f, 4, -50), new Vector3 (100, 10, 1), transform.forward, out hit, transform.rotation,Mathf.Infinity)) {
			if (isHit) {
				Debug.Log ("aaa");
				if (hit.collider.gameObject == player) {
					if (EnemyManager.state == 2 && PlayerManager.state == 1) {
						Debug.Log ("hit");
					}
				} else {
					Debug.Log ("nothit");
				}
			}
//			}
			//			Debug.DrawRay (player.transform.position, new Vector3 (0, 0, 3), Color.red, 3.0f);
		}
	}
		void OnDrawGizmos () {
			Gizmos.color = new Color(1, 1, 1, 1f);
		Gizmos.DrawCube(transform.position + new Vector3(1.3f,4,-50), new Vector3(100, 10, 1));
		}
}
