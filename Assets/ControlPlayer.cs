using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour {
	
	public GameObject mBullet;
	Rigidbody2D person1;
	Rigidbody2D person2;
	public bool ask;
	int x = 1, y = 0;
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
			if (Input.GetAxis ("Horizontal") > 0) {
				x = 1;
				y = 0;
			} else if (Input.GetAxis ("Horizontal") < 0) {
				x = -1;
				y = 0;
			}
		}
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0) {
			person1.velocity = new Vector2 (person1.velocity.x, Input.GetAxis ("Vertical") * 10);
			if (Input.GetAxis ("Vertical") > 0) {
				y = 1;
				x = 0;
			} else if (Input.GetAxis ("Vertical") < 0) {
				y = -1;
				x = 0;
			}
		}
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0) {
			person2.velocity = new Vector2 (Input.GetAxis ("Horizontal") * -10, person2.velocity.y);
			if (Input.GetAxis ("Horizontal") > 0) {
				x = 1;
				y = 0;
			} else if (Input.GetAxis ("Horizontal") < 0) {
				x = -1;
				y = 0;
			}
		}
		if (Mathf.Abs (Input.GetAxis ("Vertical")) > 0) {
			person2.velocity = new Vector2 (person2.velocity.x, Input.GetAxis ("Vertical") * 10);
			if (Input.GetAxis ("Vertical") > 0) {
				y = 1;
				x = 0;
			} else if (Input.GetAxis ("Vertical") < 0) {
				y = -1;
				x = 0;
			}
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject bullet = (GameObject) Instantiate(mBullet, person1.transform.position , new Quaternion(0,0,0,0));
			bullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (x * 20, y * 20);
			bullet = (GameObject) Instantiate(mBullet, person2.transform.position , new Quaternion(0,0,0,0));
			bullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (x * -20, y * 20);
	
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
	void OnTriggerExit2D (Collider2D Call) {
		if (Call.name == "Exit") {
			ask = false;
		}
	}


}
