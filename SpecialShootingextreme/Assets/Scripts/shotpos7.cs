﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotpos7 : MonoBehaviour {

	Vector3 pos;
	public float angle;
	public float change = 1;
	public float point;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, angle) * Time.deltaTime * change);
		pos = transform.eulerAngles;
		if (pos.z >= point + 20 && pos.z <= 360)
			change = -1;
		if (pos.z >= 180 && pos.z <= point)
			change = 1;
	}
}
