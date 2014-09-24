using UnityEngine;
using System.Collections;

public class Jock : MonoBehaviour {
	public Animator anim; 
	public float maxSpeed = 5f;
	private bool flipped = true;
	public float HP;

	// Use this for initialization
	void Start () {
		HP = 10;
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKeyDown ("space")) {
			anim.SetBool ("punch", true);
			Debug.Log ("Atack!");
		} 
		else {
			anim.SetBool ("punch", false);
		}

		HP = GameObject.Find("Health").GetComponent<Health> ().HP;
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (( Mathf.Abs(h)>0 )|| (Mathf.Abs(v)>0))
			anim.SetBool ("run", true);
		else
			anim.SetBool ("run", false);
		
		rigidbody2D.velocity = new Vector2(h * maxSpeed , rigidbody2D.velocity.y);
		rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x , v * maxSpeed);
		if (h > 0 && !flipped) {
			Flip ();
		} else if (h < 0 && flipped) {
			Flip ();
			
		}
	}
	

	void  Flip(){
		
		flipped = !flipped;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	//if enemy is in area damage is applied to the said enemy
	void OnTriggerStay2D(Collider2D col){
	if (col.tag == "Enemy") {
			if( (Input.GetKeyDown ("space")) && (HP > 0)) {
				col.GetComponent<Enemy> () .Damage ();
				Debug.Log ("Take that!");
			}
		}
	}


	

}
