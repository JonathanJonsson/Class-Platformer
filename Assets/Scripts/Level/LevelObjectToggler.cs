using UnityEngine;

public class LevelObjectToggler : MonoBehaviour
{
	[SerializeField]
	private GameObject[] gameObjectsToToggle;

	public void ToggleObjects()
	{
		foreach (var o in gameObjectsToToggle)
		{
			o.SetActive(!o.activeSelf);
		}
	}
}
