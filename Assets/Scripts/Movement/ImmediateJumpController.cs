using UnityEngine;

public class ImmediateJumpController : MonoBehaviour
{
	[SerializeField] private CommandContainer commandContainer;
 

	[SerializeField] private Rigidbody myRigidBody;
	[SerializeField] private float jumpForce = 500f;

	[SerializeField]
	private GroundChecker groundChecker;
 

	private void Update()
	{
		HandleImmediateJump();
	}

	private void HandleImmediateJump()
	{
		if (commandContainer.JumpCommandDown && groundChecker.isGrounded)
		{
			myRigidBody.AddForce(Vector3.up*jumpForce);
		}
	}
}
