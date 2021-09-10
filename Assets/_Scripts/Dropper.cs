using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float minimumTime;
    [SerializeField] float randomTime;

    MeshRenderer    meshRenderer;
    Rigidbody rigidBody;

    float dropTime;

    private void Start()
    {
        meshRenderer    = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;

        dropTime        = minimumTime + Random.value * randomTime;
    }

    // Update is called once per frame
    void Update()
    {        
        if (Time.time > dropTime)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
