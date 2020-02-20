using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRigidbody : MonoBehaviour
{
    public Rigidbody target;

    private void FixedUpdate()
    {
        transform.position = target.transform.position;
    }
}
