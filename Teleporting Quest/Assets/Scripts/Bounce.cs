using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Bounce : MonoBehaviour
{
    [SerializeField] float jumpForce = 1000f;
    
    void OnTriggerEnter(Collider other)
    {
        JumpyJumpy(other);
    }

    void JumpyJumpy(Collider other)
    {
        if (!other.TryGetComponent<FirstPersonMovement>(out FirstPersonMovement fpm))
        {
            return;
        }

        Rigidbody rb = fpm.GetComponent<Rigidbody>();
        rb.AddForce(other.transform.up * jumpForce);
    }
}
