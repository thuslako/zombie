using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {


	public AudioClip clipToPlay;
	private AudioSource myAudioSource;

	// Use this for initialization
	void Start () {
		myAudioSource = this.gameObject.GetComponent<AudioSource> ();
		myAudioSource.clip = clipToPlay;
		audio.PlayOneShot (clipToPlay,0.1f);
		GameObject.DontDestroyOnLoad (this.gameObject);
		Application.LoadLevel("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
