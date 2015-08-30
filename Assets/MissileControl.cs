using UnityEngine;
using System.Collections;

public class MissileControl : MonoBehaviour {
	public string horizontalBind = "P1_Horizontal_Mis";
	public string verticalBind = "P1_Vertical_Mis";
	public float speed = 5f;
	public float turnSpeed = 4;
	public float lifespan = 400;
	float age = 0;

	// Use this for initialization
	void Start () {
	
	}

	void Explode() {
		Destroy (gameObject);
	}

	void Update() {
		age++;

		if (age >= lifespan) {
			Explode();
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float rot = Input.GetAxis (horizontalBind);
		transform.Rotate (Vector3.up, rot);

		transform.Translate (transform.forward * speed * Time.fixedDeltaTime);
	}
}
