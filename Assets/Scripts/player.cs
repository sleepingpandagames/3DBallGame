using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public int force;
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * velocity, 0, Input.GetAxis("Vertical") * velocity);

        //
        // Move sphere using its Rigibody properties

        // if(Input.GetKey(KeyCode.F))
        //     GetComponent<Rigidbody>().AddForce(force,0,0);

        // Jump
        if(Input.GetKey(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(0,force,0);

        // Move Left
        if(Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().AddForce(-force,0,0);

        // Move Right
        if(Input.GetKey(KeyCode.RightArrow))
            GetComponent<Rigidbody>().AddForce(force,0,0);

        // Move Forward
        if(Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody>().AddForce(0,0,force);

        // Move Backward
        if(Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody>().AddForce(0,0,-force);
    }
}
