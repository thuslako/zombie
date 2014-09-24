using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float HP= 10f; 
	private SpriteRenderer bar;

	private float lastHitTime;					// The time at which the player was last hit.
	private Vector3 healthScale;				// The local scale of the health bar initially (with full health).
	//private Animator anim;					// to control player animation states

	// Use this for initialization
	void Awake (){
		bar = GameObject.Find("UI_HUD_HP").GetComponent<SpriteRenderer>();
		healthScale = bar.transform.localScale;
	}



	public void TakeDamage(float damage){
		//to trigger animations and Lose screen from here as well
		HP -= damage;
		Debug.Log("Taking damage");
		if(HP <9)
			UpdateHealth ();
	}


	public void UpdateHealth(){
		// Set the scale of the health bar to be proportional to the player's health.
		bar.transform.localScale = new Vector3(HP * 0.05107473f, 0.5243178f, 1);
		Debug.Log ("Health scale value: "+healthScale.x);
		Debug.Log ("HP Value : "+HP);
	}
}
