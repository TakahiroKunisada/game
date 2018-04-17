using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {

	public static int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter( Collider hit )
	{
		if (hit.gameObject.CompareTag ("Hoshi")) {
			Destroy (hit.gameObject);
			count++;
		}

	}
}
