using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewingMachine : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Product"))
        {
            audio.Play();
        }
    }
}
