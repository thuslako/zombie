using UnityEngine;
using System.Collections;

public class Main_Menu: MonoBehaviour {
	
	public GUIStyle style;
	public bool settings; 

	void OnGUI(){

		if (GameObject.Find ("SettingsMenu").GetComponent<Settings_Menu> ().clicked == false) {
			if (GUI.Button (new Rect ((Screen.width/2), (Screen.height/2), 128, 32), "PLAY", style)) {

				Application.LoadLevel ("Alpha");

				if (Time.timeScale == 0) {
					Time.timeScale = 1;
				}
			}

			if (GUI.Button (new Rect ((Screen.width/2), ((Screen.height/2)+40), 128, 32), "SETTINGS", style)) {
				GameObject.Find ("SettingsMenu").GetComponent<Settings_Menu> ().clicked = true;

			}
			if (GUI.Button (new Rect ((Screen.width/2), ((Screen.height/2)+80), 128, 32), "EXIT", style)) {			
				Debug.Log ("EXIT Game");
				Application.Quit ();
			}
		}
    }

}
