using UnityEngine;
using System.Collections;

public class CollCheck : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Enemy") {
			print ("dead");
		}
	}
}
