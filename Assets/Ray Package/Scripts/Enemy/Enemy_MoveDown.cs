using UnityEngine;
using System.Collections;

public class Enemy_MoveDown : MonoBehaviour {
	public float speed;
	public float hp;

	void Start() {
		rigidbody2D.velocity = new Vector2 (0, speed * -1f);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D missile){
		if(missile.tag == "missile"){
			hp -= missile.GetComponent<ShotScript>().damage;
			Destroy(missile.gameObject);
		}
		if(hp==0) Destroy(gameObject);
	}
}
