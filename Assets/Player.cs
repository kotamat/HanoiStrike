using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float force = 100;
	public float damage = 10;
	//ドラッグした距離
	public Vector2 startPoint;
	// Use this for initialization
	void Start () {


	}


	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis("Horizontal") * force;
		float y = Input.GetAxis("Vertical") * force;
		rigidbody2D.AddForce(new Vector2(x, y));

	}

	private Vector3 screenPoint;
	private Vector3 offset;

	void OnMouseDown() {
		this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		this.startPoint =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	void OnMouseUp() {
		Vector2 endPoint =  Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		rigidbody2D.AddForce((startPoint - endPoint) * force);
	}

}
