using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public static int state = 0;
	/*	0:ゲーム前
		1:ゲーム中(walk)
		2:隠れている(stop)
		3:ゲームクリア	
	*/

	void Start () {
		state = 0;
	}

	void Update () {

	}

//	void GameStart ()
//	{
//		state = 1;
//	}

}

