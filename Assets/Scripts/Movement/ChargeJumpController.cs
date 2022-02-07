using UnityEngine;
using UnityEngine.Events;

public class ChargeJumpController : MonoBehaviour
{

	
	[SerializeField]
	private CommandContainer commandContainer;

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

	[SerializeField]
	private UnityEvent<float> onChargeJump; 

	private void Update()
	{
		HandleChargedJump();
	}

	private void HandleChargedJump()
	{
		if (commandContainer.JumpCommand)
		{
			jumpCharge += Time.deltaTime/chargeTime;
			Mathf.Clamp01(jumpCharge);
		}

		if (commandContainer.JumpCommandUp)
		{
			var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);

			if (groundChecker.isGrounded)
			{
				onChargeJump.Invoke(jumpCharge);
				myRigidBody.AddForce(Vector3.up*jumpForce);
			}
			
			jumpCharge = 0f;

		}
	}
}
