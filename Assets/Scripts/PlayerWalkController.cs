using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
	[SerializeField]
	private Rigidbody myRigidBody;

	[SerializeField]
	private MovementApplier movementApplier;

	[SerializeField]
	private float moveSpeed = 5f;

	[SerializeField]
	private GroundChecker groundChecker;

	public CommandContainer commandContainer;

	[SerializeField]
	private float chargingMoveSpeedFactor = 0.5f;

	private void Update()
	{
		HandleWalking();
	}

	private void HandleWalking()
	{
		var currentMoveSpeed = moveSpeed;

		if (commandContainer.JumpCommand && groundChecker.isGrounded)
		{
			currentMoveSpeed *= chargingMoveSpeedFactor;
		}
		
		movementApplier.SetHorizontalVelocity( commandContainer.WalkCommand*currentMoveSpeed ); 
	}
}
