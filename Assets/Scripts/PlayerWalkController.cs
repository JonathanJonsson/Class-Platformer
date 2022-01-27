using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
	
	[SerializeField] private Rigidbody myRigidBody;
	[SerializeField] private float moveSpeed = 5f;

	[SerializeField]
	private GroundChecker groundChecker;
	public PlayerInputController playerInputController;

	[SerializeField]
	private float chargingMoveSpeedFactor = 0.5f;
	private void Update()
	{
		var currentMoveSpeed = moveSpeed;

		if (playerInputController.JumpInput && groundChecker.isGrounded)
		{
			currentMoveSpeed *= chargingMoveSpeedFactor;
		}
		myRigidBody.velocity = new Vector3(playerInputController.MoveInput*currentMoveSpeed, myRigidBody.velocity.y, 0) ; 
	}
}
