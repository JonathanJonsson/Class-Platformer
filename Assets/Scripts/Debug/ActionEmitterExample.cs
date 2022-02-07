using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ActionEmitterExample : MonoBehaviour
{
	public Action OnEmptyAction;
	public Action<bool, int> OnMultipleDataAction;
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
			OnRandomFloat.Invoke(Random.Range(-100f, 100f));
		}

		if (Input.GetKeyDown(KeyCode.F3))
		{
			OnTransformAction.Invoke(transform);
		}

		if (Input.GetKeyDown(KeyCode.F4))
		{
			var b = Random.Range(0f, 1f) > 0.5;
			OnMultipleDataAction.Invoke(b, Random.Range(-100, 101));
		}
	}
}
