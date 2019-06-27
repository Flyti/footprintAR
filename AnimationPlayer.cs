using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{

    public CustomCParameter[] openCustomParameters;
    public CustomCParameter[] closeCustomParameters;

    public Animator animator;

    public AnimationPlayer[] nextAnimationPlayer = null;

    public bool playnextAnimation;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AnimationPlay()
    {

        Debug.Log("AnimationPlay");
        foreach (var ccp in openCustomParameters)
        {
            Debug.Log("AnimationSet: " + ccp.paramerterName);
            switch (ccp.parameterType)
            {
                case AnimatorControllerParameterType.Bool:
                    animator.SetBool(ccp.paramerterName, Boolean.Parse(ccp.parameterValue));
                    break;
                case AnimatorControllerParameterType.Float:
                    animator.SetFloat(ccp.paramerterName, float.Parse(ccp.parameterValue));
                    break;
                case AnimatorControllerParameterType.Int:
                    animator.SetInteger(ccp.paramerterName, int.Parse(ccp.parameterValue));
                    break;
                case AnimatorControllerParameterType.Trigger:
                    animator.SetTrigger(ccp.paramerterName);
                    break;
            }
        }
    }
    public void AnimationClose()
    {
        Debug.Log("AnimationClose");
        foreach (var ccp in closeCustomParameters)
        {
            Debug.Log("AnimationSet: " + ccp.paramerterName);
            switch (ccp.parameterType)
            {
                case AnimatorControllerParameterType.Bool:
                    animator.SetBool(ccp.paramerterName, Boolean.Parse(ccp.parameterValue));
                    break;
                case AnimatorControllerParameterType.Float:
                    animator.SetFloat(ccp.paramerterName, float.Parse(ccp.parameterValue));
                    break;
                case AnimatorControllerParameterType.Int:
                    animator.SetInteger(ccp.paramerterName, int.Parse(ccp.parameterValue));
                    break;
                case AnimatorControllerParameterType.Trigger:
                    animator.SetTrigger(ccp.paramerterName);
                    break;
            }
        }
    }
    private void PlayNextAnimation()
    {

        if (nextAnimationPlayer != null)
        {
            foreach (var ap in nextAnimationPlayer)
            {
                ap.AnimationPlay();
            }
        }

    }
    public void AnimationDone()
    {
        //動畫播放完畢
        Debug.Log(animator.name + " AnimationDone");
        if (playnextAnimation)
        {
            PlayNextAnimation();

        }
    }
    public void AnimationDoneTest(AnimationPlayer animationPlayer)
    {

    }
}
