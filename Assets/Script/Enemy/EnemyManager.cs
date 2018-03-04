using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	public static int state = 0;
	/*	0:ゲーム前
		1:詠唱中(walk)
		2:詠唱後(stop)
		3:ゲームクリア	
	*/

	void Start () {
		state = 0;
	}

	void Update () {

	}


}
