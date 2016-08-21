using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.left*speed*Time.deltaTime);
	}
}
