using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ConveyorbeltExit : MonoBehaviour
{
    public float speed = 5f;
    public int rowNo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Product"))
        {
            Rigidbody rigid = other.GetComponent<Rigidbody>();
            Product p = other.GetComponent<Product>();

            if(p.row == rowNo)
            {
                rigid.velocity = (transform.position - other.transform.position).normalized * speed;

            }
        }
    }
}
