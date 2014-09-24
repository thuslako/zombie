using UnityEngine;
using System.Collections;

public class Pauser : MonoBehaviour {

	public GUITexture texture;

	void Start()
	{
				texture.enabled = false;
		}

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.P)){

			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
			}
			if(texture.enabled == false)
				texture.enabled = true;



			else
			{
				texture.enabled = false;

					Time.timeScale = 1;
			}	
	

		}
	}
}