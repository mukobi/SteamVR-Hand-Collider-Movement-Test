using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRigidbody : MonoBehaviour
{
    public Rigidbody target;

    private void Update()
    {
        transform.position = target.transform.position;
    }
}
