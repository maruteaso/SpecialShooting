using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour {
	player p;
	Rigidbody2D r2;
	enemy7wizard ene7;
	public float speed;
	public float bigspeed;
	Vector2 stop = new Vector2(0f,-8.1f);

	// Use this for initialization
	void Start () {
		GameObject a = GameObject.FindWithTag ("enemy7");
		ene7 = a.GetComponent<enemy7wizard> ();
		r2 = GetComponent<Rigidbody2D> ();
		r2.velocity = transform.up * -1 * speed;
	}
	
	// Update is called once per frame
	//特定の位置に着くと巨大化する
	void Update () {
		Vector2 judge = transform.position;
		if (stop.y >= judge.y) {
			r2.velocity = new Vector2(0,0);
			//c2.radius += Time.deltaTime * bigspeed;
			Vector3 scale = transform.localScale;
			scale.x += Time.deltaTime * bigspeed;
			scale.y += Time.deltaTime * bigspeed;
			transform.localScale = scale;
			if (scale.x >= 5) {
				Destroy (gameObject);
			}
		}
	}

	//プレイヤーに当たると上下左右反転させる関数を呼び出す
	void OnTriggerEnter2D(Collider2D c){
		string layername = LayerMask.LayerToName (c.gameObject.layer);
		if (layername == "player") {
			ene7.medapani ();
			Destroy (gameObject);
		}
	}
}
