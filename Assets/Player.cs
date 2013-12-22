using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float force = 100;
	public float damage = 10;
	// Use this for initialization
	void Start () {


	}


	// Update is called once per frame
	void Update () {
		
		float x = Input.GetAxis("Horizontal") * force;
		float y = Input.GetAxis("Vertical") * force;
		rigidbody2D.AddForce(new Vector2(x, y));

	}

}
