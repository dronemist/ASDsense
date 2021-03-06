﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody rb;
    public KeyCode moveR;
    public KeyCode moveL;
    public float forward_velociy;
    private float side_velocity = 0f ;
    private float timeLeft = 0.25f;
    // lane is 0 for middle, -1 for left and 1 for right
    public int lane = 0;
    private bool control_locked = false;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(side_velocity, rb.velocity.y, forward_velociy);
        // Increasing speed with time
        forward_velociy += 0.1f * Time.deltaTime;
        forward_velociy = Math.Min(8, forward_velociy);
        // making it move with constant speed in forward direction
        if (Input.GetKey(moveR) && lane<1 && !control_locked)
        {
            side_velocity = 5f;
            lane += 1;
            //rb.transform.Translate(2f, 0, 0);
            StartCoroutine(stopSlide());
            control_locked = true;
        }
        if (Input.GetKey(moveL) && lane>-1 && !control_locked)
        {
            side_velocity = -5f;
            lane += -1;
            //rb.transform.Translate(-2f, 0, 0);
            StartCoroutine(stopSlide());
            control_locked = true;
        }

    }
    IEnumerator stopSlide()
    {
        //rb.transform.Translate(Time.deltaTime * side_velocity, 0, 0);
        yield return new WaitForSeconds(0.4f);
        side_velocity = 0;
        control_locked = false;
    }

}
