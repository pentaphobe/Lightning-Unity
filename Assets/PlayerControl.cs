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
	float accel = 0;

	public float firingCooldown = 20;
	float firingCounter = 0;

	public Transform missilePrefab;

	Rigidbody rb;
	AudioSource engineSound;
	Transform bulletSpawnPoint;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		engineSound = GetComponent<AudioSource> ();
		bulletSpawnPoint = transform.Find ("BulletSpawnPoint");
	}

	void Update() {
		++firingCounter;

		if (Input.GetButton (attackBind) && firingCounter >= firingCooldown) {
			firingCounter = 0;
			Transform missile = Instantiate (missilePrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation) as Transform;

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

		accel += (acc - accel) * 0.05f;
		rb.AddRelativeForce (Vector3.forward * speed * accel);

		float intensity = accel;
		if (intensity < 0) {
			intensity *= -0.9f;
		}

		engineSound.volume = 0.2f + (intensity * 0.8f);
		engineSound.pitch = 1f + (intensity * 0.8f);
	}
}
