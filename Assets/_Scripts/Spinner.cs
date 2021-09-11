using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] Vector3 baseSpeed;
    [SerializeField] Vector3 randomSpeedModifier;

    private Vector3 randomRotationSpeed;
    private Vector3 finalRotationSpeed;
    // Update is called once per frame
    private void Start()
    {
        randomRotationSpeed = Random.value * randomSpeedModifier;
    }

    void Update()
    {
        finalRotationSpeed = baseSpeed + randomRotationSpeed;
        transform.Rotate(finalRotationSpeed);
    }
}
