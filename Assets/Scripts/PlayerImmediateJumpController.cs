using System;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{

	[SerializeField] private PlayerInputController PlayerInputController;
	
	[SerializeField] private Rigidbody myRigidBody;
	[SerializeField] private float jumpForce = 500f;

 

	private void Update()
	{
 
		if (PlayerInputController.JumpInput)
		{
			myRigidBody.AddForce(Vector3.up * jumpForce);
		}

	}
}
