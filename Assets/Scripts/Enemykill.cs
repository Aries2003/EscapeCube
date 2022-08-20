using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykill : MonoBehaviour
{
    static public bool ek ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ek){
            print("killed");
            Destroy(GameObject.FindGameObjectWithTag("Enemy2"));
            Destroy(GameObject.FindGameObjectWithTag("Enemy1"));
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            // Destroy(GameObject.FindGameObjectWithTag("Enemies"));
           
            
            print("ek");
            ek = false;
            EnemySpawner.Spawn = true;
        }
    }
    
    void OnTriggerEnter(Collider col) 
    { 
        //print("col");
        if (col.gameObject.tag == "Enemy2" ){    ///hit by Obstacles with respawn tag
            Destroy(GameObject.FindGameObjectWithTag("Enemy2"));//Destroy the object the player
            print("e2 killed");

        } 
        if (col.gameObject.tag == "Enemy"){    ///hit by Obstacles with respawn tag
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));//Destroy the object the player
            //  Destroy(GameObject.FindGameObjectWithTag("Enemies"));
            print("e killed");

        } 
        if (col.gameObject.tag == "Enemy1"){    ///hit by Obstacles with respawn tag
            Destroy(GameObject.FindGameObjectWithTag("Enemy1"));//Destroy the object the player
            print("e1 killed");

        } 
        
    }
}
