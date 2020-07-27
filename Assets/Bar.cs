using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DentedPixel;

public class Bar : MonoBehaviour {

    public UnityEvent onTimeEnd = new UnityEvent();

    public GameObject bar;
    public int time;


    // Start is called before the first frame update
    void Start() {
        animateBar();
    }

    // Update is called once per frame
    void Update() {
        
    }
    public void animateBar()
    {
        LeanTween.scaleX(bar, 0, time).setOnComplete(ShowMessage);
    }
   void ShowMessage()
    {
        onTimeEnd.Invoke();
    }
}

