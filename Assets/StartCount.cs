using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartCount : MonoBehaviour {

	public int count = 3;
	public Text countText;
	public bool canShoot = false;

	// Use this for initialization
	void Start () {
		InvokeRepeating("UpdateCount", 1, 1F);
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void UpdateCount() {
		if(count > -1)
			count--;

		UpdateCountText ();
	}

	private void UpdateCountText() {
		if (count > 0)
			countText.text = count.ToString ();
		else if (count == 0)
			countText.text = "GO";
		else if (count == -1)
			countText.text = "";
	}

}
