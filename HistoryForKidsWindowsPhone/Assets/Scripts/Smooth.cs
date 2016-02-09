using UnityEngine;
using System.Collections;

public class Smooth : MonoBehaviour {

    public Transform target;
	public float smoothTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	
	void Update () {
		// Define a target position above and behind the target transform
		Vector3 targetPosition = target.TransformPoint(new Vector3(2.3f, 0, -10));
		
		// Smoothly move the camera towards that target position
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition,
		                             ref velocity, smoothTime);
	}
}
