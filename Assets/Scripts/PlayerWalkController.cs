using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
	[SerializeField]
	private Rigidbody myRigidBody;

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

		myRigidBody.velocity = new Vector3(commandContainer.WalkCommand*currentMoveSpeed, myRigidBody.velocity.y, 0);
	}
}
