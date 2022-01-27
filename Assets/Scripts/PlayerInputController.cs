using System;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

	public float MoveInput;
	public bool JumpInput;
	private void Update()
	{
		MoveInput = Input.GetAxis("Horizontal");
		JumpInput = Input.GetKeyDown(KeyCode.Space);

	}
}