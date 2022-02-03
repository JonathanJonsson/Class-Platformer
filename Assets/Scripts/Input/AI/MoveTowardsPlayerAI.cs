 
using System;
using UnityEngine;

public class MoveTowardsPlayerAI : MonoBehaviour
{
 [SerializeField]   private CommandContainer commandContainer;


 [SerializeField] private Transform playerTransform;

 // private void Start()
 // {
 //  //There are cases where these are good to use, but generally it is good to hook up in inspector
 //  //so designers know whats up. Use this when it is to much to hook up in inspector.
 //  //If you need this, try using a centralized script which passes the data along to other components-
 //  //ex: enemy spawning script finds a ref to player and passes it along to the enemies spawned.
 //  
 //  
 //  // playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
 //  // playerTransform = ((PlayerIdentifier) FindObjectOfType(typeof(PlayerIdentifier))).transform; // old way
 //  // playerTransform = FindObjectOfType<PlayerIdentifier>().transform;
 // }

 private void Update()
 {

  var directionToPlayer = (playerTransform.position - transform.position).normalized;
  // var horizontalDirectionToPlayer = directionToPlayer.x;
  
  // returns -1 or 1, to prevent the normalization
  // to not return smaller than intended x-value if y-becomes great
  // (which will reduce X-influence on the normalized vector).
  
  var horizontalDirectionToPlayer = Math.Sign(directionToPlayer.x); 
  
  commandContainer.WalkCommand = horizontalDirectionToPlayer;

  
  
  
  
  
  
  

 }
}
