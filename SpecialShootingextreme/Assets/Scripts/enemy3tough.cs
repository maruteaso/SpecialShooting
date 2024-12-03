using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3tough : MonoBehaviour {

	enemac ene;

	// Use this for initialization
	void Start () {
		ene = GetComponent<enemac> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//衝突したものがプレイヤーの弾であれば、弾が当たった時の処理を行う
	void OnTriggerEnter2D(Collider2D c){
		if (ene.isplayer (c)) {
				ene.destruction (c);
		}
	}
}
