using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform target;
    public Vector3 rotationOffset;
    private void Start()
    {
        target = FindObjectOfType<PlayerManager>().transform;
    }
    void Update()
    {
        if (target != null)
        {
            // Get the direction to the target
            Vector3 direction = target.position - transform.position;

            // Calculate the target rotation
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            // Apply the offset rotation (this accounts for different axes)
            targetRotation *= Quaternion.Euler(rotationOffset);

            // Apply the rotation to the object
            transform.rotation = targetRotation;
        }
    }
}
