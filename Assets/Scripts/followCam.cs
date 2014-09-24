using UnityEngine;
using System.Collections;

public class followCam : MonoBehaviour {

	public Vector3 offset;			// The offset at which the Health Bar follows the player.
	
	private Transform Cam;		// Reference to the player.
	
	
	void Awake ()
	{
		// Setting up the reference.
		Cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
		offset = new Vector3 (-1.5f,4f,0);
	}
	
	void Update ()
	{
		// Set the position to the player's position with the offset.
		transform.position = Cam.position + offset;
	}
}
