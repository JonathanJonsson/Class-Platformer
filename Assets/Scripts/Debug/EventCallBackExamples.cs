 
using System;
using Unity.VisualScripting;
using UnityEngine;

public class EventCallBackExamples : MonoBehaviour
{
	private void Awake() => Debug.Log("Awake");
	private void Start() => Debug.Log("Start");
	private void OnEnable() => Debug.Log("OnEnable");
	private void Update() => Debug.Log("Update");
	private void LateUpdate() => Debug.Log("Late Update");
	private void FixedUpdate() => Debug.Log("Fixed Update");
	private void OnDisable() => Debug.Log("OnDisable");
	private void OnDestroy() => Debug.Log("OnDestroy");
	private void OnApplicationQuit() => Debug.Log("OnAppQuit");
	
}
