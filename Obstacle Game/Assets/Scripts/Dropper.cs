using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rnd;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        rnd = GetComponent<MeshRenderer>();
        rnd.enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rnd.enabled = true;
            rb.useGravity = true;
        }
    }
}
