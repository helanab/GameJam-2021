using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    public AudioSource jumpSound;
    public AudioSource landingSound;
    public AudioSource bark;
    public ParticleSystem barkEffect;
    public float barkRate = 1f;
    private float barkTime = 0f;

    private void Start()
    {

    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
        	jump = true;
            animator.SetBool("IsJumping", true);
            jumpSound.Play();
        }
        //bark and particle effect
        if (Input.GetKeyDown(KeyCode.F) && Time.time >= barkTime)
        {
            barkTime = Time.time + 1f / barkRate;
            bark.Play();
            barkEffect.Play();
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        landingSound.Play();
    }

    void FixedUpdate()
    {
    	controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
    	jump = false;


    }
}
