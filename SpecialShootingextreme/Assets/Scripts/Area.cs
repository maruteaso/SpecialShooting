using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour {

//Qキーで強制終了
	void Update(){
		if (Input.GetKeyDown ("q"))
			Application.Quit ();
	}

//カメラ外に飛んだ弾を削除
	void OnTriggerExit2D(Collider2D c){
		string layername = LayerMask.LayerToName (c.gameObject.layer);
		if ((layername != "player")&&(layername != "enemy")) {
			Destroy (c.gameObject);
		}
	}
}
