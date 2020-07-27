using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordHelper : MonoBehaviour
{
    public Record leftHandRecord;
    public Record rightHandRecord;
    public Record ballRecord;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            leftHandRecord.isRecording = true;
            rightHandRecord.isRecording = true;
            ballRecord.isRecording = true;
        }
        
    }

}
