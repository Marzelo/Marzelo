using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    public Sprite spriteUp;
    public Sprite spriteDown;
    public Sprite spriteLeft;
    public Sprite spriteRight;

    public Animator animator;
    public RuntimeAnimatorController walkUp;
    public RuntimeAnimatorController walkDown;
    public RuntimeAnimatorController walkLeft;
    public RuntimeAnimatorController walkRight;

    int directionIndex = 0;


	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteUp;
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.W)) {
            directionIndex = 0;
        }

        if (Input.GetKey(KeyCode.D)) {
            directionIndex = 1;
        }

        if (Input.GetKey(KeyCode.S)) {
            directionIndex = 2;
        }

        if (Input.GetKey(KeyCode.A)) {
            directionIndex = 3;
        }

        animator.SetInteger("direction", directionIndex);

        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0){
            animator.SetInteger("direction", -1);
        }

	}
}
