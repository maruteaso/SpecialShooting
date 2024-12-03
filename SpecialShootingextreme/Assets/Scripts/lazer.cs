using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour {

	enemy6lazer e6;
	public float power;
	// Use this for initialization
	//enemy6のレーザー
	void Start () {
		GameObject a = GameObject.FindWithTag ("enemy6");
		e6 = a.GetComponent<enemy6lazer> ();
	}
	
	// Update is called once per frame
	//照射中のレーザーを機体に追従させる
	void Update () {
		Vector3 pos = e6.nowpos;
		pos.y -= 16f;
		pos.x += 0.1f;
		Vector3 newpos = new Vector3 (pos.x, pos.y, transform.position.z);
		transform.position = newpos;
		//powerで指定した秒数経過後に消滅する
		Destroy (gameObject, power);
	}
}
