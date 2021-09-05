using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speedFactor; 
    [SerializeField] Vector3 speedVec; 
    [SerializeField] Vector3 controlVec;
    Vector3 speed = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        speedFactor = 2.5f;
        speedVec    = updateSpeed(speedFactor);
        controlVec  = new Vector3 (0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        // speedFactor     = 0.0015f;
        speedVec        = updateSpeed(speedFactor);

        controlVec.x    = Input.GetAxis("Horizontal");
        controlVec.z    = Input.GetAxis("Vertical");
        controlVec.Normalize();
        
        speed = Vector3.Scale(controlVec, speedVec);

        transform.Translate(speed*Time.deltaTime);
    }

    Vector3 updateSpeed(float _factor){
        return new Vector3(_factor, _factor, _factor);
    }


}
