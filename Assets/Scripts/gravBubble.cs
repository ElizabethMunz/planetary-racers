using UnityEngine;
using System.Collections;

public class gravBubble : MonoBehaviour {

	public float planetForce;
    public Vector2 dir;

	void OnTriggerStay2D (Collider2D other) 
	{

        dir = transform.position - other.transform.position;
        dir = dir.normalized;

        other.attachedRigidbody.AddForce (planetForce * dir);
	}

}
