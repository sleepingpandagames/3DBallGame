using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flagNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    // On collision with flag go to next level
    void OnTriggerEnter()
    {
        //
        // Add scenes to build settings to make it work
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
