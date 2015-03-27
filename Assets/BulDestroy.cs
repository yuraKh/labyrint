using UnityEngine;
using System.Collections;

public class BulDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D (Collider2D one)
	{
		if(one.tag == "Finish")
		{
			Destroy(gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
