using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
	
	public Rigidbody myRigidBody;
	public float moveSpeed = 5f;
	
	private void Update()
	{
		// Get move input here in Update()
		var moveInput = Input.GetAxis("Horizontal");
		
		//Set move velocity
		//preferably interact with physics in FixedUpdate()
		myRigidBody.velocity = new Vector3(moveInput*moveSpeed, myRigidBody.velocity.y, 0) ; 
	}
}
