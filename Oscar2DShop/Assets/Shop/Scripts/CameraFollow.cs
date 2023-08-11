using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float lerpSpeed = 1.0f;

    private Vector3 offset;
    private Vector3 targetPos;

    private Transform resetTarget;

    private void Start()
    {
        resetTarget = target;
        if (target == null) return;

        offset = transform.position - target.position;
    }

    private void Update()
    {
        if (target == null) return;

        targetPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);
    }

    public void ChangeTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public void ResetTarget()
    {
        target = resetTarget;
    }

}
