using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        
        rb = this.GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        PlayerMovement();

    }
    void Update()
    {
        
    }

    private void PlayerMovement()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
