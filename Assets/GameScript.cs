using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

	public GameObject broom;
	public GameObject obstacle;

	private Vector3 startingPos = new Vector3(-6f,-1f,0f);
	private Vector3 startingRot = new Vector3 (-56f, -137f, 46f);

	// Use this for initialization
	void Start () {
		Instantiate (obstacle, new Vector3 (-4f, -1f, 0f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
