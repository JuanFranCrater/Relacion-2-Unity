using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamara : MonoBehaviour {
	Camera[] camaras= new Camera[2];
	bool camara=true;
	// Use this for initialization
	void Start () {
		Camera.GetAllCameras(camaras);
		camaras [1].enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			if (camara) {
				camaras [0].enabled = false;
				camaras [1].enabled = true;
			
				camara = false;
			} else {
				camaras [1].enabled = false;
				camaras [0].enabled = true;
				camara = true;
			}
		}
	}
}
