using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{

    string text1 = "Number1";
    string text2 = "Number2";

    int numInteger = 0;

    public int spin;

    public bool isSpinning; // always False if not initialized

    // Start is called before the first frame update
    void Start()
    {
        
        if(numInteger == 1)
            name = text1;
        else
            name = text2;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0,0,5);
        
        //if(isSpinning == true)
        //    transform.Rotate(0,spin,0);

        //if (Input.GetButtonDown("Fire1"))
            //transform.Translate(1,0,0);
        
        transform.Translate(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    }
}
