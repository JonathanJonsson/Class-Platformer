using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody myRigidBody;
	public float moveSpeed = 5f;
	public float jumpForce = 500f;

	private void Update() 
	{
		// Get move input here in Update()
		var moveInput = Input.GetAxis("Horizontal");
		
		//Set move velocity
		//preferably interact with physics in FixedUpdate()
		myRigidBody.velocity = new Vector3(moveInput*moveSpeed, myRigidBody.velocity.y, 0) ; 
		
		//get jump input
		// Get move input here in Update()
		var jumpInput = Input.GetKeyDown(KeyCode.Space);

		//jump if jump input
		//preferably interact with physics in FixedUpdate()
		if (jumpInput)
		{
			myRigidBody.AddForce(Vector3.up * jumpForce);
		}
 
	}

 
}