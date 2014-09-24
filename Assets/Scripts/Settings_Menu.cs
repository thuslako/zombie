using UnityEngine;
using System.Collections;

public class Settings_Menu : MonoBehaviour {
	
	public GUISkin  btnstyle3;
	public GUIStyle exStyle;
	public GUIStyle popup;

	public bool toggleSwitch1;
	public bool toggleSwitch2;
	public float EndPosY = 0f;
	public float StartPosY = 1.15f;

	public Vector3 EndPos;
	public Vector3 StartPos;
	public bool clicked; 


	void Start (){

	}
	
	void FixedUpdate(){

	}

	void OnGUI(){

		if (clicked){

			GUI.skin.box = popup;
			GUI.Box (new Rect(Screen.width /2 + 70,Screen.height /2-80,250,250), "Settings");


			GUI.skin = btnstyle3;
			
			if(toggleSwitch1 == true){
				
			}
			else{
				toggleSwitch1 = false;
			}
			//toggle switch two 
			if(toggleSwitch2 == true){
				AudioListener.pause = false;
			}
			else{
				toggleSwitch2 = false;
				AudioListener.pause = true;
			}
			toggleSwitch1 = GUI.Toggle (new Rect (((Screen.width/2)+ 240), ((Screen.height/2)-8), 64, 32),toggleSwitch1," ");
			toggleSwitch2 = GUI.Toggle (new Rect (((Screen.width/2)+ 240), ((Screen.height/2)+50), 64, 32),toggleSwitch2," ");
			
			
			if (GUI.Button (new Rect (((Screen.width/2)+ 280), ((Screen.height/2)-70), 30, 30), " ", exStyle)) {
				
				Debug.Log ("EXIT Game");
				clicked = false;
			}
		}
	}


}

