using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) //check if player presses button w
        {
            //move in the direction the player is face
            transform.position += transform.forward * speed * Time.deltaTime
        }

    }
}
