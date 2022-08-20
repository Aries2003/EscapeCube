using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour
{
    public GameObject playerSpawn;
  
    void OnTriggerEnter(Collider col2) 
    { 

        if (col2.gameObject.tag == "Border"){    ///off the ground respawn (Ground Check)
            
            Destroy(playerSpawn); //Destroy object in player not grounded
            Enemykill.ek = true;
            Spawner.respawn = true;
            // EnemySpawner.Spawn = true;
            // print("fall off the ground");


        } 
    }  
}
