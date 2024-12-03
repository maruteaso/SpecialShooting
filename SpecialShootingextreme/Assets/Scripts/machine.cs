using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class machine : MonoBehaviour {

	public GameObject explosion;
	public GameObject bullet;
	public float shotdelay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//指定した弾を発射する
	public void shot(Transform here){
		Instantiate (bullet, here.position, here.rotation);
	}

	//破壊モーションを発生させる
	public void bang(){
		Instantiate (explosion, transform.position, transform.rotation);
	}
}
