using UnityEngine;
using System.Collections;

public class gravBubble : MonoBehaviour {

	public float planetForce;


	void OnTriggerStay2D (Collider2D other) 
	{
		other.attachedRigidbody.AddForce (planetForce * other.attachedRigidbody.velocity);
	}

}
