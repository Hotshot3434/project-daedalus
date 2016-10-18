using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 5;
    public float jumpForce = 200;
    public bool isGrounded = false;
    
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        //Horizontal Movement
        this.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * movementSpeed * Time.deltaTime;


        //Jumping
        if (isGrounded && Input.GetAxis("Jump") != 0)
        {
            rb.AddForce(new Vector3(0, Input.GetAxis("Jump"), 0) * jumpForce);
            isGrounded = false;
        }
	}

    //TODO: Find out why the collider will not trigger these functions
    void OnTriggerEnter(Collider other)
    {
        isGrounded = true;
        Debug.Log("Trigger Enter");
    }
    void OnTriggerExit(Collider other)
    {
        isGrounded = false;
        Debug.Log("Trigger Exit");
    }
}
