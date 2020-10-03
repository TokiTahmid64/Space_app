using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_hode_2 : MonoBehaviour {
	public GameObject info;
	private bool show=true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void show_hide()
	{
		if(!show)
		{
			info.SetActive(true);
			show=true;
		}
		else
		{
			info.SetActive(false);
			show=false;
		}
	}
}
