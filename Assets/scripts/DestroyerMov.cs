using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerMov : MonoBehaviour
{
    public Rigidbody curr;
    public PlayerMov movement;
    private float z_speed; 
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        z_speed = movement.rb.velocity.z;
        curr.velocity = new Vector3(0,0,z_speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
