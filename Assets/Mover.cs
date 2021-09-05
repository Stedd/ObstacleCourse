using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speedFactor = 0.0001f;
    Vector3 speed = new Vector3();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed.x = speedFactor*Mathf.Sin(Time.realtimeSinceStartup);
        speed.y = 0;
        speed.z = speedFactor*Mathf.Cos(Time.realtimeSinceStartup);
        // transform.Position(0,0,0);
        transform.Translate(speed);
    }
}
