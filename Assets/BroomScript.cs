using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroomScript : MonoBehaviour {

	private Vector3 startPos;
	private Vector3 endPos;



	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (0f, 0f, 1f) * 0.5f;
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.position -= new Vector3 (0f, 0f, 1f) * 0.5f;
		}
	}
}
