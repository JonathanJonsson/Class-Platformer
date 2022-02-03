 
using UnityEngine;

[CreateAssetMenu(fileName = "WalkSpeedData", menuName = "Data/Walk")]
public class WalkSpeedSO : ScriptableObject
{
  [SerializeField] private float walkSpeed = 5f;
  public float WalkSpeed => walkSpeed;
}