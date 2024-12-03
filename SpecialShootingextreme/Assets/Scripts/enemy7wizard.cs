using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy7wizard : MonoBehaviour {

	player p;
	public float delay;
	public GameObject spell;
	enemac ene;
	// Use this for initialization
	void Start () {
		GameObject a = GameObject.FindWithTag ("Player");
		p = a.GetComponent<player> ();
		ene = GetComponent<enemac> ();
		StartCoroutine ("Spell");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//プレイヤーの行動を錯乱させる弾を発射する
	IEnumerator Spell(){
		while (true) {
			if (Input.GetKeyDown ("h")|| ene.a == 1) {
				Instantiate (spell, transform.position, transform.rotation);
				yield return new WaitForSeconds (delay);
			}
			yield return new WaitForSeconds (0);
		}
	}

	//プレイヤーの行動を上下左右逆転させる
	public void medapani(){
		StartCoroutine ("ender");
	}

	IEnumerator ender(){
		p.speed *= -1;
		yield return new WaitForSeconds (10);
		p.speed *= -1;
	}

}
