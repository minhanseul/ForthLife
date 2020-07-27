using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabsound : MonoBehaviour
{
    public AudioSource grabSource;

    // Start is called before the first frame update
    void Start()
    {
        grabSource = GetComponent<AudioSource>();         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    { if (collision.gameObject.tag == "Target")
        {

            grabSource.Play();
        }
    }
}
