using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyorbelt : MonoBehaviour
{
    public float speed = 3f;
    public int rowA;
    public int rowB;

    public Transform endPoint;
    public Transform APoint;
    public Transform BPoint;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Product"))
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, endPoint.position, speed * Time.deltaTime);
        }
    }
}
