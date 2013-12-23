using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	public float life = 100;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D obj){
		if(obj.gameObject.name == "Player"){
			life -= obj.gameObject.GetComponent<Player>().damage;
		}

		if(life <= 0){
			Destroy(gameObject);
		}

	}
}
