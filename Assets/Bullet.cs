using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 5f;
	public Transform pos;
	public Rigidbody2D rigidbody;
	public GameController gameCon;
	// Use this for initialization
	void Start () {
		float x = PlayerController._instance.h;
		transform.localEulerAngles = new Vector3 (0,0,x);
		rigidbody = GetComponent<Rigidbody2D> ();
		transform.Rotate (new Vector3(0,0,90));
		gameCon = GameObject.Find ("Camera").GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down*speed*Time.deltaTime);

	} 
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Enemy") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
			gameCon.SendMessage ("AddScore");
		}
		if (col.tag == "Wall") {
			Destroy (this.gameObject);
		}
	}
}
