using UnityEngine;
using System.Collections;

public class LevelResetter : MonoBehaviour {
	public Transform player1;
	public Transform player2;
	public Transform player1StartPosition;
	public Transform player2StartPosition;

	// Use this for initialization
	void Start () {
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Reset() {
		player1.transform.position = player1StartPosition.position;
		player2.transform.position = player2StartPosition.position;
		player1.transform.rotation = player1StartPosition.rotation;
		player2.transform.rotation = player2StartPosition.rotation;
	}
}
