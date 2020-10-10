using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();

        if (!myAnimator)
        {
            Debug.LogError("Component missing: " + myAnimator.GetType());
        }
    }

    public void SetWalkingState(bool isMoving)
    {
        myAnimator.SetBool("isMoving", isMoving);
    }

    public void UpdateSpeed(float speed)
    {
        myAnimator.SetFloat("speed", speed);
    }
}
