using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
	public Rigidbody myRigidBody;
	public float jumpForce = 500f;

	
	private void Update()
	{
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
