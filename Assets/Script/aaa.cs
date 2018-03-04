using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour {

	RaycastHit hit;

	[SerializeField]
	bool isEnable = false;

	void OnDrawGizmos()
	{
		if (isEnable == false)
			return;

		var scale = transform.lossyScale.x * 10f;

		var isHit = Physics.BoxCast (transform.position, Vector3.one * scale, transform.forward, out hit, transform.rotation);
		if (isHit) {
			Gizmos.DrawRay (transform.position, transform.forward * hit.distance);
			Gizmos.DrawWireCube (transform.position + transform.forward * hit.distance, Vector3.one * scale * 2);
		} else {
			Gizmos.DrawRay (transform.position, transform.forward * 100);
		}
	}
}
