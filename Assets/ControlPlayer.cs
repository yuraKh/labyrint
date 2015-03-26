using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour {

	//public Transform sens;
	//public LayerMask pol;
	public Transform bullet;
	private Vector2 _target;
	public float force = 100f;
	Rigidbody2D person1;
	Rigidbody2D person2;
	public bool ask;
	// Use this for initialization
	void Start () {
		person1 = GameObject.Find("Player1").GetComponent<Rigidbody2D> ();
		person2 = GameObject.Find("Player2").GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0) {
			person1.velocity = new Vector2 (Input.GetAxis ("Horizontal") * 10, person1.velocity.y);
		}
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0) {
			person1.velocity = new Vector2 (person1.velocity.x, Input.GetAxis ("Vertical") * 10);
		}

		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0) {
			person2.velocity = new Vector2 (Input.GetAxis ("Horizontal") * -10, person2.velocity.y);
		}
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0) {
			person2.velocity = new Vector2 (person2.velocity.x, Input.GetAxis ("Vertical") * 10);
		}

		if (Input.GetKey(KeyCode.Space))
		{

			
		}
	}

	void OnTriggerStay2D (Collider2D Call) {
		if (Call.name == "Exit") {
			ask = true;
			if (person1.GetComponent<ControlPlayer>().ask == person2.GetComponent<ControlPlayer>().ask){
				Destroy(gameObject);
			}
				
		}
	}


}
