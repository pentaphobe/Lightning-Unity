using UnityEngine;
using System.Collections;

public class ZoomCamera : MonoBehaviour {
	public float lerpSpeed = 0.002f;

	// Use this for initialization
	void Start () {
		transform.localEulerAngles = new Vector3 (90, 0, 0);
		transform.position = new Vector3 (0, 20, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		ZoomCameraTarget[] targets = Resources.FindObjectsOfTypeAll (typeof(ZoomCameraTarget)) as ZoomCameraTarget[];

		Vector3 positionAccumulator = new Vector3 ();

		foreach (ZoomCameraTarget target in targets) {
			positionAccumulator += target.transform.position;
		}

		positionAccumulator /= targets.Length;
		Debug.Log (positionAccumulator);

		positionAccumulator.y = 20;

		Vector3 delta = positionAccumulator - transform.position;
		delta *= lerpSpeed;
		delta += transform.position;

		transform.position = delta;

	}
}
