using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    float xValue;
    float yValue;
    float zValue;
    void Start()
    {
        xValue = GetComponent<Transform>().position.x;
        yValue = GetComponent<Transform>().position.y;
        zValue = GetComponent<Transform>().position.z;
    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            transform.position = new Vector3(xValue, yValue, zValue);
        }
    }
}
