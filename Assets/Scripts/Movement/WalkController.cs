using UnityEngine;

public class WalkController : MonoBehaviour
{
	[SerializeField]
	private Rigidbody myRigidBody;

	// // [SerializeField]
	// private float moveSpeed = 5f;

	[SerializeField]
	private WalkSpeedSO walkSpeedSO;
	
	[SerializeField]
	private GroundChecker groundChecker;

	public CommandContainer commandContainer;

	[SerializeField]
	private float chargingWalkSpeedFactor = 0.5f;

	private void Update()
	{
		HandleWalking();
	}

	private void HandleWalking()
	{
		var currentMoveSpeed = walkSpeedSO.WalkSpeed;

		if (commandContainer.JumpCommand && groundChecker.isGrounded)
		{
			currentMoveSpeed *= chargingWalkSpeedFactor;
		}
		
		myRigidBody.velocity = new Vector3( commandContainer.WalkCommand*currentMoveSpeed , myRigidBody.velocity.y,0); 
	}
}
