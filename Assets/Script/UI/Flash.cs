using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flash : MonoBehaviour {
	[SerializeField]
	GameObject Qtext;
	float a_color;
	bool flag_G;

	void Start () {
		a_color = 0;
	}

	void Update () {
		//テキストの透明度を変更する
		Qtext.GetComponent<Text>().color = new Color (0, 0, 0, a_color);
		if (flag_G) {
			a_color -= Time.deltaTime;
		} else {
			a_color += Time.deltaTime;
		}
		if (a_color < 0) {
			a_color = 0;
			flag_G = false;
		} else if (a_color > 1){
			a_color = 1;
			flag_G = true;
		}
	}
}
