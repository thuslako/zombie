using UnityEngine;
using System.Collections;

public class CameraFollow: MonoBehaviour {
	private Transform player; // Reference to the player's transform.
	public float speed= 0.1f;

		
	void Awake () { // Setting up the reference. 
		player = GameObject.FindGameObjectWithTag("Player").transform;

	}
	
	void FixedUpdate () { 
		TrackPlayer();
	} 
	
	void TrackPlayer () {
		transform.position = Vector3.Lerp (transform.position, player.position, speed * Time.deltaTime);
		//unlinking z from lerp position change
		Vector3 temp = transform.position;
		temp.x = Mathf.Clamp (transform.position.x, -14.5f, 14f);
		temp.y = Mathf.Clamp (transform.position.y, 1.45f, 2f);
		temp.z = -10f;
		transform.position = temp;
		//limiting  horizontal and vertical distance of camera

	}

}
