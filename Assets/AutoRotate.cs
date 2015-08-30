using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {
	public float rotationSpeed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (Vector3.up, rotationSpeed);
	}
}
