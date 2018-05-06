using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour { 
	[SerializeField] 
	GameObject player;
	[SerializeField] 
	GameObject wall;
	[SerializeField]
	public LayerMask mask;
	RaycastHit hit;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			
//			if (Physics.BoxCast (player.transform.position + new Vector3 (0, 0, 3), new Vector3 (1.5f, 2, 1), transform.forward, out hit, transform.rotation,mask)) {
//				if (wall.gameObject.layer == LayerMask.NameToLayer ("Wall")) {
//					gameObject.layer = LayerMask.NameToLayer ("Ignore Raycast");
//					Debug.Log ("a");
//				}
			}
			 else {
				gameObject.layer = LayerMask.NameToLayer ("Player");
//				Debug.Log ("b");
			}
				
//			Debug.DrawRay (player.transform.position, new Vector3 (0, 0, 3), Color.red, 3.0f);
//		}
	}
	void OnDrawGizmos () {
		Gizmos.color = new Color(1, 0, 0, 0.5F);
		Gizmos.DrawCube(player.transform.position + new Vector3(0,0,3), new Vector3(2, 2, 6));
	}
}