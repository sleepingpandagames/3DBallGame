using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCoin : MonoBehaviour
{

    Vector3 rotateDirection;

    // Update is called once per frame
    void Update()
    {
        rotateDirection = new Vector3(0,90,0);

        transform.Rotate(rotateDirection*Time.deltaTime);       
    }
}
