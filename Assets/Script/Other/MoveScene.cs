using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour {

	[SerializeField]
	string scene = "";
	public static string stage;

	public void TapTo_MoveScene(){
		Debug.Log ("TAP");
		SceneManager.LoadScene (scene);
		stage = scene;
	}

	public void TapTo_Retry(){
		Debug.Log ("R");
		SceneManager.LoadScene (Main.stage);
	}

}
