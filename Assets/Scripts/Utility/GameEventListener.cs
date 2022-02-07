 using System;
 using UnityEngine;
 using UnityEngine.Events;

 public class GameEventListener : MonoBehaviour
{

 [SerializeField]
 private GameEvent gameEvent;

 [SerializeField]
 private UnityEvent onGameEvent; //should get invoked when game event emits

 private void OnEnable()
 {
  gameEvent.OnGameEvent += InvokeUnityEvent;
 }

 private void OnDisable()
 {
  gameEvent.OnGameEvent -= InvokeUnityEvent;
 }

 private void InvokeUnityEvent()
 {
  onGameEvent.Invoke();
 }


}
