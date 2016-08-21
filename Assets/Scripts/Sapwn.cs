using UnityEngine;
using System.Collections;

public class Sapwn : MonoBehaviour {
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Create",1f,1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Create()
	{
		float x = Random.Range (4.8f,7.0f);
		float y = Random.Range (-4.41f,4.8f);
		GameObject.Instantiate (enemy,new Vector3(x,y,0),Quaternion.identity);
	}
}
