﻿using UnityEngine;
using System.Collections;

public class coneCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		// jos objekti törmäsi maahan
		if (coll.gameObject.CompareTag ("Ground")) {
			gameObject.SetActive(false);
		}
	}
}
