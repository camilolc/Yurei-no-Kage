using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Akane_CharacterController : MonoBehaviour
{
    //private CharacterController controller;
    //private Vector3 playerVelocity;
    //private bool groundedPlayer;
    //private float playerSpeed = 1.0f;
    //private float gravityValue = -9.81f;
    //private Animator animator;

    //private void Start()
    //{
    //    animator = GetComponent<Animator>();
    //    controller = gameObject.GetComponent<CharacterController>();
    //}

    //void Update()
    //{
    //    groundedPlayer = controller.isGrounded;
    //    if (groundedPlayer && playerVelocity.y < 0)
    //    {
    //        playerVelocity.y = 0f;
    //    }
    //    Vector3 move = new Vector3(Input.GetAxis("Vertical"), 0.0f, Input.GetAxis("Horizontal") *-1);
    //    controller.Move(move * Time.deltaTime * playerSpeed);

    //    if (move != Vector3.zero)
    //    {
    //        gameObject.transform.forward = move;
    //        animator.SetBool("isWalk", true);
    //    }
    //    else {
    //        animator.SetBool("isWalk", false);
    //    }

    //    playerVelocity.y += gravityValue * Time.deltaTime;
    //    controller.Move(playerVelocity * Time.deltaTime);
    //}

    Rigidbody rb;
    public float speed = 10.0F;
    public float rotationSpeed = 50.0F;
    Animator animator;
    static public bool dead = false;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        Quaternion turn = Quaternion.Euler(0f, rotation, 0f);
        rb.MovePosition(rb.position + this.transform.forward * translation);
        rb.MoveRotation(rb.rotation * turn);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2;
        }

        

        if (translation != 0)
        {
            animator.SetBool("isWalk", true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }



        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(playerVelocity * Time.deltaTime);

        //if (translation != 0)
        //{
        //    animator.SetBool("Idling", false);
        //}
        //else
        //{
        //    animator.SetBool("Idling", true);
        //}

        //if (dead)
        //{
        //    animator.SetTrigger("isDead");
        //    this.enabled = false;
        //}


    }
}