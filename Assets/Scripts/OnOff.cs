using UnityEngine;
using System.Collections;

public class OnOff : MonoBehaviour {
	public GUIText on;
	public GUIText off;

	// Use this for initialization
	void Start () {
		off.enabled = true;
		on.enabled = false;
		AudioListener.pause = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		if (AudioListener.pause == false) {
			
			AudioListener.pause = true;
		}

		if(off.enabled == true)
			off.enabled = false;
		
		if(on.enabled == false)
			on.enabled = true;




		else
		{
			AudioListener.pause = false;

			off.enabled = true;
			on.enabled = false;




		}	


	}
}
