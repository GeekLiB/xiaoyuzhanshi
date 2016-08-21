using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
	public  Text scoreText;
	public int index=0;
	// Use this for initialization
	void Start () {
		scoreText.text = index + "";
	}
	
	// Update is called once per frame
	void Update () {
	   
	}
	public void AddScore()
	{
		index++;
		scoreText.text = index + "";

	}
}
