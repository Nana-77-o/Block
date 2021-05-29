using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControrer : MonoBehaviour
{
    float accel = 1000.0f;
    Rigidbody rb;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Impulse);

    }
}
