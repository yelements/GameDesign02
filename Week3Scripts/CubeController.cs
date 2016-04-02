using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {
	public int Score;
	// Update is called once per frame
	void Update () {
		float speed = 15 * Time.deltaTime; //Our Speed in seconds

		if (Input.GetKey (KeyCode.UpArrow)) {
			Debug.Log ("Up Arrow was Pressed");
			transform.Translate (Vector3.forward * speed);
		}	
		if (Input.GetKey (KeyCode.DownArrow)) {
			Debug.Log ("Down Arrow was Pressed");
			transform.Translate (Vector3.back * speed);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			Debug.Log ("Left Arrow Pressed");
			transform.Translate (Vector3.left * speed);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log ("Right Arrow Pressed");
			transform.Translate (Vector3.right * speed);
		}
	
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "coin") {
			Score++;
			Debug.Log (Score);
			Destroy (other.gameObject);
		}
	}
			
}
