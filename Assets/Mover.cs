using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Vector3 speedFactor; 
    [SerializeField] Vector3 controlVecRaw;
    [SerializeField] Vector3 controlVec;
    [SerializeField] Vector3 speedVec; 

 
    // Start is called before the first frame update
    void Start()
    {
        speedFactor = new Vector3 (7.5f,7.5f,7.5f);
        controlVec  = new Vector3 (0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        controlVecRaw = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        controlVec = calcControlVec(controlVecRaw);
        
        speedVec = Vector3.Scale(controlVec, speedFactor);

        transform.Translate(speedVec*Time.deltaTime);
    }

    Vector3 calcControlVec(Vector3 _ctrlVec){
        float _x = 0;
        float _y = 0;
        float _z = 0;
        float angXZ = Vector3.AngleBetween(new Vector3(0,0,1),_ctrlVec);
        _x = _ctrlVec.x * Mathf.Sin(angXZ);
        _z = _ctrlVec.z * Mathf.Abs(Mathf.Cos(angXZ));
        return new Vector3(_x, _y, _z);
    }




}
