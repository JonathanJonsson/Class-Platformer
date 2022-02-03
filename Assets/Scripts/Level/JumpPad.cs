 
using System;
using UnityEngine;

public class JumpPad : MonoBehaviour
{

	[SerializeField]
	private float jumpForce = 1500f;
	private void OnTriggerEnter(Collider other)
	{
		// var otherRigidbody = other.GetComponent<Rigidbody>();
		// if (otherRigidbody == null)
		// 	return;
		// otherRigidbody.AddForce(transform.up * jumpForce);
		
		// if (other.TryGetComponent(out Rigidbody rb))
		// {
		// 	rb.AddForce(transform.up * jumpForce);
		// }
		
		other.GetComponent<Rigidbody>()?.AddForce(transform.up * jumpForce);
	}
	 
	
	
}
