using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	//弾速の変数
	public int speed = 10;

	// 弾速を設定
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
	}
	
	//4秒後に消える
	void Update () {
		string layername = LayerMask.LayerToName (gameObject.layer);
		if(layername != "enemybullet")
			Destroy (gameObject,4);
	}
}
