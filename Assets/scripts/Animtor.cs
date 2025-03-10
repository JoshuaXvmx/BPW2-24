using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animtor : MonoBehaviour
{
    public Animator animator;
    public string animationClipName = "YourAnimationClipName"; // Replace with your clip name

    void OnEnable()
    {
        if (animator != null)
        {
            animator.Play(animationClipName);
        }
        else
        {
            Debug.LogError("Animator not assigned to PlayAnimationOnEnable script on " + gameObject.name);
        }
    }
}
