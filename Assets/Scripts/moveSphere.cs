using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveSphere : MonoBehaviour
{
    
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public int ballSpeed;
    public bool isGrounded;
    private int coinCount;
    public Text coinText;
    
    Rigidbody rb;
    
    // Init on start
    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        isGrounded = false;
        coinCount = 0;
        coinText.text = "Coins: " + coinCount;
    }
    
    // Check everytime if a Rigidbody object is on collision with a collider
    // Tip: Removed this because it will allow kind of double jumps
    // void OnCollisionStay()
    // {
    //     isGrounded = true;
    // }

    // Init isGrounded once ball enters on a collision with a collider
    void OnCollisionEnter()
    {
        isGrounded = true;
    }

    // Every game moment
    // void Update()
    // {

    //     // Move (4 directions)
    //     float moveH = Input.GetAxis ("Horizontal");
    //     float moveV = Input.GetAxis ("Vertical");

    //     Vector3 ballMove = new Vector3 (moveH, 0.0f, moveV);

    //     // Time.deltaTime makes movements look smoother
    //     GetComponent<Rigidbody>().AddForce(ballMove*ballSpeed*Time.deltaTime);

    //     //
    //     // Jump
    //     //
    //     // Jump - Keyboard
    //     if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

    //         rb.AddForce(jump * jumpForce, ForceMode.Impulse);
    //         isGrounded = false;
    //     }
    //     // 
    //     // Jump - Gamepad
    //     if(Input.GetButtonDown("Jump") && isGrounded){

    //         rb.AddForce(jump * jumpForce, ForceMode.Impulse);
    //         isGrounded = false;
    //     }

    // }

    void Update()
    {

        // 
        // Moves (4 directions)
        float moveH = Input.GetAxis ("Horizontal");
        float moveV = Input.GetAxis ("Vertical");

        Vector3 ballMove = new Vector3 (moveH, 0.0f, moveV);

        // Do not allow player to control moves if he isn't on the gound
        if(isGrounded)
        {
            // Time.deltaTime makes movements look smoother
            GetComponent<Rigidbody>().AddForce(ballMove*ballSpeed*Time.deltaTime);
        }

        //
        // Jump
        //
        // Jump - Keyboard
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        // 
        // Jump - Gamepad
        if(Input.GetButtonDown("Jump") && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }

    //
    // Collectibles
    private void OnTriggerEnter(Collider other)
    {
        // If our ball enters in collision with another object with tag "Item"
        if (other.gameObject.CompareTag("Item"))
        {
            // Then destroy that object
            other.gameObject.SetActive(false);

            // Increment coin count
            coinCount = coinCount + 1;
            coinText.text = "Coins: " + coinCount;
        }
    }
}
