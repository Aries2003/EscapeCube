using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstsclesMovement : MonoBehaviour
{
    float TimeCounter = 0;
    public float speed = 2.5f;

    public float range = 0;

    public float z;
    public float y = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        // while(startgame)
        // {
                TimeCounter += Time.deltaTime * speed;

                float x = Mathf.Sin  (TimeCounter ) *range;
                

                transform.position = new Vector3 (x,y,z);

       // }
    }
}
