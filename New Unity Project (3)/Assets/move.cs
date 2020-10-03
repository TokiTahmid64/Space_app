using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,speed*Time.deltaTime,0);
		
	}
	public void change()
	{
		speed=-speed;
	}
}
