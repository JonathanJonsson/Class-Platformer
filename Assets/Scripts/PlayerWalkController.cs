using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
	
	[SerializeField] private Rigidbody myRigidBody;
	[SerializeField] private float moveSpeed = 5f;

	public PlayerInputController PlayerInputController;
	private void Update()
	{
		myRigidBody.velocity = new Vector3(PlayerInputController.MoveInput*moveSpeed, myRigidBody.velocity.y, 0) ; 
	}
}
