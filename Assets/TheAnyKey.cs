using UnityEngine;
using System.Collections;

public class TheAnyKey : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown || Input.GetButton("P1_Fire") || Input.GetButton ("P2_Fire") || Input.GetButton ("Submit")) {
			Application.LoadLevel ("Control test");
		}
	}
}
