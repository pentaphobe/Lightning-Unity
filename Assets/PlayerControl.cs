using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public string attackBind = "P1_Fire";
	public string horizontalBind = "P1_Horizontal";
	public string verticalBind = "P1_Vertical";
	public string horizontalMissileBind = "P1_Horizontal_Mis";
	public string verticalMissileBind = "P1_Vertical_Mis";
	public float speed = 20;
	public float turnSpeed = 4;

	public Transform missilePrefab;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update() {
		if (Input.GetButton (attackBind)) {
			Transform missile = Instantiate (missilePrefab, transform.position + transform.forward * 2, Quaternion.identity) as Transform;
			MissileControl mc = missile.GetComponent<MissileControl>();
			mc.horizontalBind = horizontalMissileBind;
			mc.verticalBind = verticalMissileBind;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float rot = Input.GetAxis (horizontalBind);
		transform.Rotate (Vector3.up, rot * turnSpeed);
		float acc = Input.GetAxis (verticalBind);

		rb.AddRelativeForce (Vector3.forward * speed * acc);

	}
}
