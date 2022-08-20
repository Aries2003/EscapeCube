using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killTrigger : MonoBehaviour
{
    public GameObject playerSpawn;
    

    void OnTriggerEnter(Collider col) 
    { 
        //print("col");
        if (col.gameObject.tag == "Respawn"){    ///hit by Obstacles with respawn tag
            Destroy(playerSpawn);//Destroy the object the player
            //print("Respawn");
           
            Enemykill.ek = true;
            // print("kill true");
            Spawner.respawn = true;
            // EnemySpawner.Spawn = true;
            
        } 

        
    }  

}
