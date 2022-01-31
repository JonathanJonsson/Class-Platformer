using UnityEngine;

public class CommandContainer : MonoBehaviour
{
	//These fields are visible in inspector, used for testing. But also dangerous,
	//might want to use getters/setters or [HideInInspector]
	
	public float WalkCommand ;
	public bool JumpCommandDown ;
	public bool JumpCommandUp ;
	public bool JumpCommand;
	
	
	
	
}
