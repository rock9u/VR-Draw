using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPressed : MonoBehaviour {
	public GameObject score = GameObject.Find("score");
	private UIDisplayFlow UIScript;
	// Use this for initialization
	void Start () {
		UIScript = score.GetComponent<UIDisplayFlow>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter (Collider other){
		this.gameObject.setActive(false);
		UIScript.inGame = true;

	}
}
