﻿using UnityEngine;
using System.Collections;

public class startifstatements : MonoBehaviour {

	public bool fact = true;
	// Use this for initialization
	void Start () {
		if (fact == true) {
			fact = false;
			if (fact == false) {
				Debug.Log ("Fact was switched to false");
			} else {
				Debug.Log ("ERROR");
			}
		} else {
			Debug.Log ("Condition wasn't met");
		}


		//multi If Statement
//		if (10 < 20) {
//			Debug.Log (3+4*5+1);
//		}
//
//		if (fact == true) {
//			Debug.Log (fact);
//		}
//		if (5 < 20) {
//			fact = false;
//			Debug.Log (fact);
//		}

		//Standard IfElse Statement
		//		if (10 < 20) {
		//			Debug.Log (3+4*5+1);
		//		}

//		 else {
//			Debug.Log (1*8+(10-5));
//		
//	}
	}
	
//	// Update is called once per frame
//	void Update () {
//	
//	}
}
