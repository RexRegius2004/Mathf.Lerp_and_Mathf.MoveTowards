using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float duration = 5f;

    private float elapsedTime = 0f;

    void Update()
    {
        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);
        }
    }
}