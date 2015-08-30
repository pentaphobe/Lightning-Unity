using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScore : MonoBehaviour {

	public Text scoreText;
	public int score = 0;

	// Use this for initialization
	void Start () {
		SetScore ();
	}
	
	// Update is called once per frame
	void Update () {
		SetScore ();
	}

	void SetScore () {
		scoreText.text = score.ToString ();
	}
}
