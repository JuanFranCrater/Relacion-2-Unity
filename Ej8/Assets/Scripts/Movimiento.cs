using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	float _xpos = 0.0F;
	float _zpos = 0.0F;
	float _velocidad=1F;


	void Start () {
		
	}
	

	void Update () {
		_xpos = Input.GetAxis ("Horizontal") * Time.deltaTime * _velocidad;

		_zpos = Input.GetAxis ("Vertical") * Time.deltaTime * _velocidad;
		transform.Translate (_xpos, 0, _zpos);

		Vector3 positionClamp = transform.position;

		positionClamp.z = Mathf.Clamp (transform.position.z, -14.5F, 14.5F);
		positionClamp.x = Mathf.Clamp (transform.position.x, -9.5F, 9.5F);

		transform.position = positionClamp;
		transform.rotation = new Quaternion(0,0,0,0);
	}
}
