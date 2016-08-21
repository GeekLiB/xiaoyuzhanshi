using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public  static PlayerController _instance;
	public GameObject bullet;
	public Transform pos;
	public Sprite[] players;
	public float rate = 5;
	public int length = 0;
	public float timer = 0;
	public int index = 0;
	public float SpriteInterval;
	public SpriteRenderer spriterender;
	public int groundIndex=0;
	public float h;
	public int num=0;
	void Awake()
	{
		PlayerController._instance = this;
	}
	// Use this for initialization
	void Start () {
		length = players.Length;
		SpriteInterval = 1 / rate;
		groundIndex = LayerMask.GetMask ("Ground");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			num++;
			CreateBullet ();
		}
		 h += Input.GetAxis ("Mouse X")*8f;
		h = Mathf.Clamp (h,-80,80);
		transform.localEulerAngles = new Vector3 (0,0,h);

		timer += Time.deltaTime;
		if (timer >= SpriteInterval) {
			timer =0;
			index++;
			index %= length;
			spriterender.sprite=players[index];
		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Enemy") {
			//print ("hah");
		}
	}
	void CreateBullet()
	{
		GameObject.Instantiate (bullet,pos.position,Quaternion.identity);
		
	}

}
