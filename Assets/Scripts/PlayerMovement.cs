using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 5;
    public float jumpForce = 5;

    private bool isGrounded = false;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        this.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * movementSpeed * Time.deltaTime;
        
        if (isGrounded)
        {
            this.transform.position += new Vector3(0, Input.GetAxis("Jump"), 0)*jumpForce*Time.deltaTime;
            isGrounded = false;
        }
	}
}
