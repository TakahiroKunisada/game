using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour {
	GameObject player;
	[SerializeField]
	private Color change_color;
	[SerializeField]
	private Color origin_color;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
//		if (Physics.BoxCast (transform.position + new Vector3 (0, 0, -1), new Vector3 (10, 2.5f, 1), transform.forward, out hit, transform.rotation,Mathf.Infinity)) {
//			if (hit.collider.gameObject == player) {
//				ColorChange ();
//			} else {
//				ColorReset ();
//			}
//		}
	}

	public void ColorChange(){
		Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();

		foreach(Renderer renderer in renderers)
		{
			renderer.material.color = change_color;
		}
	}

	public void ColorReset(){
		Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();

		foreach(Renderer renderer in renderers)
		{
			renderer.material.color = origin_color;
		}
	}

}
