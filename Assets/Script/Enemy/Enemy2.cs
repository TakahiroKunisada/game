using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
	[SerializeField]
	[Tooltip("回転の向き")]
	float direction;
	[SerializeField]
	[Tooltip("回転速度")]
	float speed;
	[SerializeField]
	float width;
	[SerializeField]
	float height;
	[SerializeField]
	float pos_x;
	[SerializeField]
	float pos_z;
	private float time;

	// Use this for initialization
	void Start () {
//		InvokeRepeating ("Repeate", 1,2);
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime * speed;


		float x = Mathf.Cos(Time.time * speed) * width;
		float z = Mathf.Sin(Time.time * speed) * height;
		float y = 0f;
		transform.position = new Vector3(x + pos_x, y, z + pos_z);

		transform.position = new Vector3( Mathf.Clamp (transform.position.x, -20f, 20f),
													   transform.position.y,
										  Mathf.Clamp (transform.position.z, 20f, 113f));

	}
		
	void Repeate(){
		time += 90;
	}

}
