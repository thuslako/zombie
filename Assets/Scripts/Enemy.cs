using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float moveSpeed = 5f;		// The speed the enemy moves at.
	public int HP = 2;					// How many times the enemy can be hit before it dies.
	public float damage= 1f;           
	private GameObject playerHP;
	public float smooth= 3f;
	public float damageTiming= 2f; 				// set the delay for enemy hits
	public float repeatDamagePeriod = 2f;
	private float lastHitTime;					// The time at which the player was last hit.
	private Vector3 healthScale;		
	

	void Start(){
		playerHP = GameObject.Find("Health");
	}

	void Update() {

	}

	void OnTriggerStay2D(Collider2D col){
		if (col.tag == "Player") {
			if (Time.time > lastHitTime + repeatDamagePeriod){
				if( (playerHP.GetComponent<Health> ().HP) > 0){
					playerHP.GetComponent<Health> ().TakeDamage(damage);
					Debug.Log ("Take that!");
					lastHitTime = Time.time; 
				}
			}
		}
	}

	public void Damage(){
		--HP;
		Debug.Log (" hit -1: "+ HP);

		if (HP == 0)
			Destroy (gameObject);
	}

	//For applying damage to Player -- explore once we figure out attack of zombie and Jock
//	void OnCollisionEnter2D (Collision2D col){
//			//play animation for attack
//			col.gameObject.GetComponent<Jock>() .Death();
//	}




}
