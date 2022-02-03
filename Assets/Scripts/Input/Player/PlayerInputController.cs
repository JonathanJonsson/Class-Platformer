using System;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

	[SerializeField]
	private CommandContainer commandContainer;
	//currently these fields are not accessed from other scripts, but leave them public to show example.
	//These could be made private or removed.
	public float WalkInput { get; private set; }
	public bool JumpInputDown { get; private set; }
	public bool JumpInputUp { get; private set; }
	public bool JumpInput  { get; private set; }
	
	private void Update()
	{
		GetInput();
		SetCommands();
	}

	private void GetInput()
	{
		WalkInput = Input.GetAxis("Horizontal");
		JumpInputDown = Input.GetKeyDown(KeyCode.Space);
		JumpInputUp = Input.GetKeyUp(KeyCode.Space);
		JumpInput = Input.GetKey(KeyCode.Space);
	}

	private void SetCommands()
	{
		commandContainer.WalkCommand = WalkInput;
		commandContainer.JumpCommandDown = JumpInputDown;
		commandContainer.JumpCommandUp = JumpInputUp;
		commandContainer.JumpCommand = JumpInput;
	}
}