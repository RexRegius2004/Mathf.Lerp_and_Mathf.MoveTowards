using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;

    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}