﻿using UnityEngine;
using System.Collections;

public class FlyPickup : MonoBehaviour {

	[SerializeField]
	private GameObject pickupPrefab;
	void OnTriggerEnter (Collider other) {

		// if the collider "other" is tagged with "player"
		if (other.CompareTag ("Player")) {

			// adding pickup particles
			Instantiate(pickupPrefab, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}

	}

}