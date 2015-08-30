using UnityEngine;
using System.Collections;

public class MissileControl : MonoBehaviour {
	public string attackBind = "P1_Fire";
	public string horizontalBind = "P1_Horizontal";
	public string verticalBind = "P1_Vertical";
	public float speed = 0.00001f;

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
