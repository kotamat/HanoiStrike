using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	public Transform enemy;
	public float life = 100;
	// Use this for initialization
	void Start () {

	//	Instantiate(enemy,Vector2(Random.Range(-4,4),Random.Range(-7,7)), transform.rotation);
	
	}
	
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
