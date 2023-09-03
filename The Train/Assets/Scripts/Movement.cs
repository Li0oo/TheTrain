using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerMovement : MonoBehaviour
{
    public float Wspeed = 5f;
    public float rotationspeed = 250;

    public Animator animator;

    private float x, y;


    void Update()
    {
        x = Input.GetAxis("Horizontal");

        y = Input.GetAxis("Vertical");


        transform.Rotate(0, x * Time.deltaTime * rotationspeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * Wspeed);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}