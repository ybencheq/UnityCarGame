using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up"))
			transform.Translate(Vector3.forward*10f*Time.deltaTime); //frame dependent speed

		if (Input.GetKey("down"))
			transform.Translate(Vector3.back*10f*Time.deltaTime); //frame dependent speed

		if (Input.GetKey("left"))
			transform.Rotate(Vector3.up, -50f*Time.deltaTime); //frame dependent speed

		if (Input.GetKey("right"))
			transform.Rotate(Vector3.up, 50f*Time.deltaTime); //frame dependent speed
		
	}
}
