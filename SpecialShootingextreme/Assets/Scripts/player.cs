using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
	machine mac;
	SpriteRenderer sp;
	public float speed;
	BoxCollider2D co2d;
	emitter em;

	// Use this for initialization
	void Start(){
		GameObject a = GameObject.FindWithTag ("emitter");
		em = a.GetComponent<emitter> ();
		co2d = GetComponent<BoxCollider2D> ();
		mac = GetComponent<machine> ();
		StartCoroutine ("after");
		sp = GetComponent<SpriteRenderer> ();
	}
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");
		Vector2 direction = new Vector2 (x, y).normalized;
		Move(direction);
	}

	//カメラ外に行かないように制限をかけながら移動する
	void Move(Vector2 direction){
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));
		Vector2 pos = transform.position;
		pos += direction * speed * Time.deltaTime;
		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);

		transform.position = pos;

	}

	//zキーで弾を発射するコルーチン
	IEnumerator after(){
		while (true) {
			if(Input.GetKey("z")){
				mac.shot (transform);
				yield return new WaitForSeconds (mac.shotdelay);
			}
			yield return new WaitForSeconds (0);
		}
	}

	//衝突判定
	void OnTriggerEnter2D(Collider2D c){
		string layername = LayerMask.LayerToName (c.gameObject.layer);

		//敵弾に衝突したら自壊する
		if (layername == "enemybullet") {
			Destroy (c.gameObject);
		}
		//自壊後の処理
		if (layername == "enemybullet" || layername == "enemy") {
			StopCoroutine ("after");
			co2d.enabled = false;
			sp.enabled = false;
			mac.bang ();
			Invoke ("change", 2f);
			em.saving ();
		}
	}

	//endシーンに切り替える
	void change(){
		SceneManager.LoadScene ("end");
	}

}
