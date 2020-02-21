using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionForward : MonoBehaviour
{
    public Rigidbody rb;
    public float speedMetersPerSec;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.MovePosition(transform.position + transform.forward * speedMetersPerSec * Time.fixedDeltaTime);
    }
}
