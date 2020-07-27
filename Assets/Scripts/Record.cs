using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;

public class Record : MonoBehaviour
{
    public bool isRecording = false;
    public AnimationClip clip;

    private GameObjectRecorder m_Recorder;

    private void Update()
    {
        if (m_Recorder == null && isRecording)
            TryInitialize();
    }

    void TryInitialize()
    {
        // Create recorder and record the script GameObject.
        m_Recorder = new GameObjectRecorder(gameObject);

        // Bind all the Transforms on the GameObject and all its children.
        m_Recorder.BindComponentsOfType<Transform>(gameObject, true);
    }

    void LateUpdate()
    {
        if (m_Recorder == null)
            return;

        if (clip == null)
            return;

        // Take a snapshot and record all the bindings values for this frame.
        m_Recorder.TakeSnapshot(Time.deltaTime);
    }


    void OnDisable()
    {
        if (clip == null || !isRecording)
            return;

        if (m_Recorder == null)
            return;

        if (m_Recorder.isRecording)
        {
            // Save the recorded session to the clip.
            m_Recorder.SaveToClip(clip);
        }
    }
}
