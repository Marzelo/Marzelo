using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformerMovement : MonoBehaviour {

    public float gravity;
    float verticalSpeed;
    public float jumpForce;

    bool isGrounded;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isGrounded)
        {
            verticalSpeed -= gravity * Time.deltaTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalSpeed = jumpForce;
                isGrounded = false;
            }
        }

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, verticalSpeed * Time.deltaTime, 0);
	}

	void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Platform")){
            isGrounded = true;
            verticalSpeed = 0;
        }
	}
}
