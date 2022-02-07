using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ActionEmitterExample : MonoBehaviour
{
	public  Action OnEmptyAction;
	public Action<float> OnRandomFloat; 
	public Action<Transform> OnTransformAction; 

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.F1))
		{
			OnEmptyAction.Invoke();
		}
		
		if (Input.GetKeyDown(KeyCode.F2))
		{
			OnRandomFloat.Invoke(Random.Range(-100f,101f));
		}
		if (Input.GetKeyDown(KeyCode.F3))
		{
			OnTransformAction.Invoke(transform);
		}
	}
}
