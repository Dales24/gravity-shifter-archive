using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class new_Movement : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            animator.SetBool("isWalking", true);

        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey("e"))
        {
            animator.SetBool("isJumping", true);
        }

        if (!Input.GetKey("e"))
        {
            animator.SetBool("isJumping", false);
        }

        if (Input.GetKey("a"))
        {
            animator.SetBool("isLeft", true);

        }

        if (!Input.GetKey("a"))
        {
            animator.SetBool("isLeft", false);
        }

        if (Input.GetKey("d"))
        {
            animator.SetBool("isRight", true);

        }

        if (!Input.GetKey("d"))
        {
            animator.SetBool("isRight", false);
        }

    }
}
