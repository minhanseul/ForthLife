using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomTriggerMaker : MonoBehaviour
{
    public UnityEvent OnRandomTriggerEnter;

    public float maxTimeGap;

    private float currentTime = 0f;
    private float nextTime;

    private void Start()
    {
        nextTime = Random.value * maxTimeGap;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= nextTime)
        {
            OnRandomTriggerEnter.Invoke();

            currentTime = 0f;
            nextTime = Random.value * maxTimeGap;
        }
    }
}
