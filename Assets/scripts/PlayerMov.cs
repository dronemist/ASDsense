using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody rb;
    public KeyCode moveR;
    public KeyCode moveL;
    public float forward_velociy;
    public float side_velocity = 0f ;
    // lane is 0 for middle, -1 for left and 1 for right
    public int lane = 0;
    public bool control_locked = false;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(side_velocity, rb.velocity.y, forward_velociy);
        // making it move with constant speed in forward direction
        if (Input.GetKey(moveR) && lane<1 && !control_locked)
        {
            side_velocity = 8f;
            lane += 1;
            StartCoroutine(stopSlide());
            control_locked = true;
        }
        if (Input.GetKey(moveL) && lane>-1 && !control_locked)
        {
            side_velocity = -8f;
            lane += -1;
            StartCoroutine(stopSlide());
            control_locked = true;
        }

    }
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(0.25f);
        side_velocity = 0;
        control_locked = false;
    }

}
