using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Animator leftHandAnimator;
    public Animator rightHandAnimator;

    public void ActivateAnimation(string s)
    {
        leftHandAnimator.SetTrigger(s);
        rightHandAnimator.SetTrigger(s);
    }
}
