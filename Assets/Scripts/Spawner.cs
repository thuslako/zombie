using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public float spawnTime = -1f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public GameObject Zombie;	


	// Use this for initialization
	void Start () {
		Instantiate (Zombie, transform.position, transform.rotation);
	}
	

}
