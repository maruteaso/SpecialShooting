using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy5cannon : MonoBehaviour {

	public GameObject cannon;
	public GameObject[] bully;
	public float avility;
	enemac ene;
	machine mac;
	// Use this for initialization
	void Start () {
		mac = GetComponent<machine> ();
		ene = GetComponent<enemac> ();
		StartCoroutine ("Cannon");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//大砲を射出
	IEnumerator Cannon(){
		while (true){
			if (Input.GetKey ("h")|| ene.auto) {
				Instantiate (cannon, transform.position, transform.rotation);
				yield return new WaitForSeconds (avility);
			}
			yield return new WaitForSeconds (0);
		}

	}

	//大砲がプレイヤーに当たった後、右側に集中的に弾を撃つ
	public void bullying(){
		Invoke ("r", 5);
		mac.shotdelay = 0.13f;
		foreach (GameObject a in bully) {
			GameObject bully1 = (GameObject)Instantiate (a, transform.position, Quaternion.identity);
			bully1.transform.parent = transform;
		}
	}

	public void r(){
		mac.shotdelay = 0.17f;
	}

}
