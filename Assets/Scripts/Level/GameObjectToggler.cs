using UnityEngine;

public class GameObjectToggler : MonoBehaviour
{


	public void ToggleGO()
	{
		gameObject.SetActive(!gameObject.activeSelf);
	}	
	
}
