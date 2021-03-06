using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	float _xpos = 0.0F;
	float _zpos = 0.0F;
	Rigidbody rb;

	float _impulso=20F;


	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	

	void Update () {
		_xpos = Input.GetAxis ("Vertical") * Time.deltaTime * _impulso/5;
		_zpos = Input.GetAxis ("Horizontal") * Time.deltaTime * _impulso/5;



		transform.Translate (-_xpos, 0, _zpos);

		Vector3 positionClamp = transform.position;

		positionClamp.z = Mathf.Clamp (transform.position.z, -7F, 7F);
		positionClamp.x = Mathf.Clamp (transform.position.x, -7F, 7F);

		if (Input.GetKeyDown ("space")&&transform.position.y==2) {
			
			rb.AddForce (transform.up * _impulso*15);

		} else {
			transform.position = positionClamp;
		}



	}
}
