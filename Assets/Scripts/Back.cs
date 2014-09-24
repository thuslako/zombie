using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	public GUIText startgame;
	public GUIText settings;
	public GUIText exit;
	public GUIText sound;
	public GUIText on;
	public GUIText off;
	public GUIText back;
	
	// Use this for initialization
	void Start () {
		
		startgame.enabled = true;
		settings.enabled = true;
		exit.enabled = true;
		sound.enabled = false;
		on.enabled = false;
		off.enabled = false;
		back.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnMouseDown(){
		
		if(startgame.enabled == false)
			startgame.enabled = true;
		
		if(settings.enabled == false)
			settings.enabled = true;
		
		if(exit.enabled == false)
			exit.enabled = true;
		
		if(sound.enabled == true)
			sound.enabled = false;
		
		if(on.enabled == true)
			on.enabled = false;
		
		if(off.enabled == true)
			off.enabled = false;
		
		if(back.enabled == true)
			back.enabled = false;
		
		
	}
	
}
