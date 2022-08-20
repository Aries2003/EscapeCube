using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject e,e1,e2;
    static public bool Spawn ;

    
    // Start is called before the first frame update
    void Start()
    {
        Spawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Spawn){//if respawn condition are met
            print("inside Enemy respawn");
            Instantiate(e, transform.position, transform.rotation);
            Instantiate(e1, transform.position, transform.rotation);
            Instantiate(e2, transform.position, transform.rotation);   
        }
        Spawn = false;
       
    }
}
