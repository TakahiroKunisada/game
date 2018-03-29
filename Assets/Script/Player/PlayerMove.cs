using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//プレイヤーの動き(ジャイロ)
public class PlayerMove : MonoBehaviour {
	public Rigidbody rb;
	public static float force = 9.81f;
	public static float speed = 0.15f;
	[SerializeField]
	private float x_speed;
	[SerializeField]
	private float z_speed;
	[SerializeField]
	private Color change_color;
	[SerializeField]
	private Color origin_color;
	private Vector3 position;
	private Gyroscope gyroscope;
	public Transform gravity;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		Input.gyro.enabled = true;
		gyroscope = Input.gyro;
	}

	void Update(){
		
	}

	void FixedUpdate(){
		if (Input.GetMouseButton (0)) {
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			ColorChange ();
			PlayerManager.state = 2;
		} else {
//			Vector3  dir = Vector3.zero; 
//			dir.x = Input.acceleration.x * x_speed; 
//			dir.z = Input.acceleration.y * z_speed;
//			dir.y = 0;
//			rb.AddForce(dir *force);
			PlayerManager.state = 1;
			ColorReset ();
			Vector3 position = new Vector3( gyroscope.gravity.x * z_speed, 0, gyroscope.gravity.y * x_speed) * speed;
			transform.position += position;
//			float gyroScale  = 2;

//			//左右に傾けたときの重力ベクトルの値の差を左右の移動とする
//			float	h = Mathf.Clamp(Input.gyro.gravity.y * gyroScale, -1.0, 1.0);
//			//手前・奥に傾けたときの重力ベクトルの値の差を手前・奥の移動とする
//			float v = Mathf.Clamp(-1 * (Input.gyro.gravity.x - 0.6) * gyroScale, -1.0, 1.0);

			}
		//移動制限
		transform.position = new Vector3( Mathf.Clamp (transform.position.x, -39f, 39f),
										  transform.position.y,
										  Mathf.Clamp (transform.position.z, -4f, 135f));
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