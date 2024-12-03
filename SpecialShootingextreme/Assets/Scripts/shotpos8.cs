using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotpos8 : MonoBehaviour {

	GameObject ene4;

	// Use this for initialization
	void Start () {
		ene4 = GameObject.FindWithTag ("enemy4");
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 now = transform.position;
		Vector2 parentpos = ene4.transform.position;
		now.x = parentpos.x * -1;
		now.y = parentpos.y;
		transform.position = now;
	}
}
