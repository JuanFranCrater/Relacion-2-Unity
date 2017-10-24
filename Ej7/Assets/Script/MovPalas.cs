using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPalas : MonoBehaviour {

	public KeyCode _up ;
	public KeyCode _down ;
	public float _velocidad=2F;
	float _posz;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(_up))
		{_posz =- _velocidad*Time.deltaTime;}
		if(Input.GetKey(_down))
		{_posz = _velocidad*Time.deltaTime;}
		transform.Translate (0, 0,_posz);
		Vector3 positionClamp = transform.position;
		positionClamp.z = Mathf.Clamp (transform.position.z,-5.0F,5.0F);
		transform.position = positionClamp;
		_posz = 0;
	}
}
