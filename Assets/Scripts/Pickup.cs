using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	/// <summary>
	/// This script expects a collider2d with IsTrigger checked off
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="collider">Collider.</param>

	void OnTriggerEnter2D (Collider2D collider)
	{
		if (collider.gameObject.tag == "Player") 
		{
			var gc = GameObject.FindGameObjectWithTag("GameController");

			gc.GetComponent<GameController>().IncrementScore(1);

			Destroy(gameObject);
		}
	}
}
