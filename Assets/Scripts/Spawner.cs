using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject playerSpawn;

    static public bool respawn;
    
    // Start is called before the first frame update
    void Start()
    {
       //print("inside start");
       respawn = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(respawn){//if respawn condition are met

            Instantiate(playerSpawn, transform.position, transform.rotation);
           
            // print("inside respawn");
            // EnemySpawner.Spawn = true;
        }
        respawn = false;
    }
}
