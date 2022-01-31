using UnityEngine;

public class MovementApplier : MonoBehaviour
{
	[SerializeField]
	private Rigidbody myRigidBody;

	public Vector3 StoredVelocity  => storedVelocity; //short hand for public get, private set;
	private Vector3 storedForce;

	
	private Vector3 storedVelocity;

	private void FixedUpdate()
	{
		ApplyVelocity();
		ApplyForce();
	}

	private void ApplyVelocity()
	{
		myRigidBody.velocity = storedVelocity;
		// storedVelocity = myRigidBody.velocity; //could skip reset

	}

	private void ApplyForce()
	{
		myRigidBody.AddForce(storedForce); // add force
		storedForce = Vector3.zero; //After added set the added force to 0
		// storedVelocity = myRigidBody.velocity;
	}

	public void SetHorizontalVelocity(float horizontalVelocity)
	{
		SetVelocity(new Vector3(horizontalVelocity, myRigidBody.velocity.y, myRigidBody.velocity.z)); 
	}

	public void SetVelocity(Vector3 velocity)
	{
		storedVelocity = velocity;
	}

	public void AddForce(Vector3 force)
	{
		storedForce += force;
	}
}
