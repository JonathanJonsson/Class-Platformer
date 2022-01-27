using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
	
	[SerializeField] private Rigidbody myRigidBody;
	[SerializeField] private float moveSpeed = 5f;

	public PlayerInputController playerInputController;
	private void Update()
	{
		myRigidBody.velocity = new Vector3(playerInputController.MoveInput*moveSpeed, myRigidBody.velocity.y, 0) ; 
	}
}
