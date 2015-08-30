using UnityEngine;
using System.Collections;

public class MissileControl : MonoBehaviour {
	public string horizontalBind = "P1_Horizontal_Mis";
	public string verticalBind = "P1_Vertical_Mis";
	public float speed = 5f;
	public float turnSpeed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float rot = Input.GetAxis (horizontalBind);
		transform.Rotate (Vector3.up, rot);

		transform.Translate (transform.forward * speed * Time.fixedDeltaTime);
	}
}
