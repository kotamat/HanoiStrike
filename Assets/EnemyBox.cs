using UnityEngine;
using System.Collections;

public class EnemyBox : MonoBehaviour {

	public Transform enemy;
	// Use this for initialization
	void Start () {

		Instantiate(enemy,new Vector3(Random.Range(-4,4),Random.Range(-7,7),0), transform.rotation);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
