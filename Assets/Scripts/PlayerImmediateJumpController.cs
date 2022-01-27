using System;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{

	[SerializeField] private PlayerInputController playerInputController;
	
	[SerializeField] private Rigidbody myRigidBody;
	[SerializeField] private float jumpForce = 500f;

	[SerializeField]
	private GroundChecker groundChecker;
 

	private void Update()
	{
 
		if (playerInputController.JumpInput && groundChecker.isGrounded)
		{
			myRigidBody.AddForce(Vector3.up * jumpForce);
		}

	}
}
