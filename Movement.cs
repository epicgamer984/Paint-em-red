using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float xRange = 10.0f;

    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    private Rigidbody playerRb;

    public bool hasCoin;


    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(transform.forward * speed * forwardInput);

        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            playerRb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    
    void Start(){
        playerRb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    void OnCollisionStay(){
        isGrounded = true; }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Coin"))
        {hasCoin = true;
        Destroy(other.gameObject);
        }
    }

}
