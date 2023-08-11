using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public Transform target;
    public Animator canvasAnimator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cameraFollow.ChangeTarget(target);
        canvasAnimator.SetTrigger("On");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        cameraFollow.ResetTarget();
        canvasAnimator.SetTrigger("Off");
    }

}
