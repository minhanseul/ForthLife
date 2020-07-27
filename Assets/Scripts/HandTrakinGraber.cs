using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HandTrakinGraber : OVRGrabber
{
    public AudioClip grabBeginAudio;
    public AudioClip grabEndAudio;

    private AudioSource audio;

    public UnityEvent OnGrabBegin;
    public UnityEvent OnGrabEnd;


    private OVRHand hand;

    public float pinchTreshold = 0.7f;

    protected override void Start()
    {
        base.Start();
        hand = GetComponent<OVRHand>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CheckIndexPinch();
    }

    void CheckIndexPinch()
    {
        float pinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength > pinchTreshold;
        bool debugPinching = isPinching;

        if (isPinching)
        {
            Debug.Log("Pinching");
        }

        if (!m_grabbedObj && isPinching && m_grabCandidates.Count > 0)
        {
            GrabBegin();
            OnGrabBegin.Invoke();
        }
        else if (m_grabbedObj && !isPinching)
        {
            GrabEnd();
            OnGrabEnd.Invoke();
            Debug.Log("Grab End");
        }
    }

    public void PlayGrabSound()
    {
        audio.PlayOneShot(grabBeginAudio);
    }

    public void PlayGrabEndSound()
    {
        audio.PlayOneShot(grabEndAudio);
    }



}
