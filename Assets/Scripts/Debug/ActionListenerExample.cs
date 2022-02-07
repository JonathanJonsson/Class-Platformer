using UnityEngine;


//Only one listener in this example, but one big advantage with events is that you can have multiple listeners listening for the same event!
public class ActionListenerExample : MonoBehaviour
{
	[SerializeField]
	private ActionEmitterExample actionEmitter;

	private void OnEnable() => Subscribe();

	private void OnDisable() => UnSubscribe();

	private void Subscribe()
	{
		actionEmitter.OnEmptyAction += EmptyActionMethod;
		actionEmitter.OnRandomFloat += RandomFloatActionMethod;
		actionEmitter.OnTransformAction += TransformActionMethod;
		actionEmitter.OnMultipleDataAction += MultipleDataMethod;
	}

	private void UnSubscribe()
	{
		actionEmitter.OnEmptyAction -= EmptyActionMethod;
		actionEmitter.OnRandomFloat -= RandomFloatActionMethod;
		actionEmitter.OnTransformAction -= TransformActionMethod;
		actionEmitter.OnMultipleDataAction -= MultipleDataMethod;

	}

	//it is not required to be static, but fits nicely in this case
	private static void EmptyActionMethod() => Debug.Log("Empty action was emitted");

	private static void RandomFloatActionMethod(float value) => Debug.Log($"Our random float was {value}");

	private static void TransformActionMethod(Transform emittedTransform) => emittedTransform.position += Vector3.up;

	private static void MultipleDataMethod(bool boolValue, int intValue) => Debug.Log($"Our bool is {boolValue} and our int is {intValue}");
}
