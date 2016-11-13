using UnityEngine;
using System.Collections;

public class gravBubble : MonoBehaviour {

	public float planetForce = 120f;


	void OnTriggerStay2D (Collider other) 
	{
		if (other.attachedRigidbody) 
			other.attachedRigidbody.AddForce (Vector2.down * planetForce, ForceMode.Acceleration);
	}

}
