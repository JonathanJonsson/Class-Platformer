using UnityEngine;
using UnityEngine.Events;

public class ImmediateJumpController : MonoBehaviour
{
	[SerializeField] private CommandContainer commandContainer;
 

	[SerializeField] private Rigidbody myRigidBody;
	[SerializeField] private float jumpForce = 500f;

	[SerializeField]
	private GroundChecker groundChecker;
	
	[SerializeField] private UnityEvent onJump;
	 
	

	private void Update()
	{
		HandleImmediateJump();
	}

	private void HandleImmediateJump()
	{
		if (commandContainer.JumpCommandDown && groundChecker.isGrounded)
		{
			onJump.Invoke();
			myRigidBody.AddForce(Vector3.up*jumpForce);
		}
	}
}
