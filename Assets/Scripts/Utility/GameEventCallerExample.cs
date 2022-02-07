using System;
using UnityEngine;

public class GameEventCallerExample : MonoBehaviour
{


	[SerializeField]
	private KeyCode keyToCallGameEvent;

	[SerializeField]
	private GameEvent gameEventToCall;

	private void Update()
	{
		if (Input.GetKeyDown(keyToCallGameEvent))
		{
			gameEventToCall.OnGameEvent.Invoke(); // invoke out game event
		}
	}
}
