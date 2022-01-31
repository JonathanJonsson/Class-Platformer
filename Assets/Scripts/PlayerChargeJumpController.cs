using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{

	
	[SerializeField]
	private PlayerInputController playerInputController;

	[SerializeField]
	private Rigidbody myRigidBody;

	[SerializeField]
	private GroundChecker groundChecker;

	[SerializeField]
	private float maximumJumpForce = 1000f;

	[SerializeField]
	private float minimumJumpForce = 100f;

	[SerializeField]
	private float chargeTime = 1f;

	private float jumpCharge = 0f;

	private void Update()
	{
		HandleChargedJump();
	}

	private void HandleChargedJump()
	{
		if (playerInputController.JumpInput)
		{
			jumpCharge += Time.deltaTime/chargeTime;
		}

		if (playerInputController.JumpInputUp)
		{
			var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
			jumpCharge = 0f;

			if (groundChecker.isGrounded)
			{
				myRigidBody.AddForce(Vector3.up*jumpForce);
			}
		}
	}
}
