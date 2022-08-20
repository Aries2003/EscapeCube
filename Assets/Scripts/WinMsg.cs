using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMsg : MonoBehaviour
{
    
    public GameObject playerSpawn;
        void OnTriggerEnter(Collider col1) 
    { 
        //print("col1");
        if (col1.gameObject.tag == "Finish"){//Touched the finish line 
            Destroy(playerSpawn);
            // Enemykill.ek = true;
            SceneManager.LoadScene(4, LoadSceneMode.Single);//Changing scene for Win msg
            
        } 
    }  
}
