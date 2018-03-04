using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {


	//カメラにアタッチされている
	//カメラの移動
	private GameObject player = null;
	private Vector3 offset = Vector3.zero;  //offsetの初期化
	[SerializeField]
	private float speed;
	[SerializeField]
	private float c_pos;
	private Gyroscope gyroscope;
	public Transform gravity;
	Transform m_transform;


	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");  //Playerを探す
		offset = transform.position - player.transform.position; //自分の位置からPlayerの位置を引く
		gyroscope = Input.gyro;
		m_transform = transform;
	}

	void LateUpdate () {
		if (player != null) {
			if (PlayerManager.state == 2) {
				transform.rotation = Quaternion.Euler (new Vector3(13,gyroscope.gravity.x * speed,0));
			} else {
				transform.rotation = Quaternion.Euler (13, 0, 0);
			}
			Vector3 newPosition = transform.position;     //Playerを追従する
			newPosition.x = player.transform.position.x + offset.x;           //カメラのx軸の位置
			newPosition.y = c_pos;          //カメラのy軸の位置
			newPosition.z = player.transform.position.z + offset.z;
			transform.position = newPosition;
		}
	}
}