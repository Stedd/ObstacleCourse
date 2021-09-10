using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Vector3 speedBase; 
    [SerializeField] Vector3 speedModifier; 
    [SerializeField] Vector3 controlVecRaw;
    [SerializeField] Vector3 controlVecScaled;
    [SerializeField] Vector3 speedVec; 

    [SerializeField] float actualSpeed;

 
    // Start is called before the first frame update
    void Start()
    {
        PrintInstuctions();

        speedBase           = new Vector3 (7.5f,7.5f,7.5f);
        speedModifier       = new Vector3 (1f,1f,1f);
        controlVecScaled    = new Vector3 (0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer(){
        controlVecRaw       = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("UpDown"),Input.GetAxis("Vertical"));
        controlVecScaled    = CalculateScaledControlVector(controlVecRaw);

        speedVec            = Vector3.Scale(speedModifier, Vector3.Scale(controlVecScaled, speedBase));
        actualSpeed         = Vector3.Magnitude(speedVec);
        
        transform.Translate(speedVec*Time.deltaTime);
    }

    Vector3 CalculateScaledControlVector(Vector3 _ctrlVec){
        // This function scales down the control vector to ensure speed
        // does not exceed Base speed when moving in multiple axes simultaneously.
        float _x = _ctrlVec.x * ScaleControlVectorAxis(new Vector3(1,0,0),_ctrlVec);
        float _y = _ctrlVec.y * ScaleControlVectorAxis(new Vector3(0,1,0),_ctrlVec);
        float _z = _ctrlVec.z * ScaleControlVectorAxis(new Vector3(0,0,1),_ctrlVec);
        return new Vector3(_x, _y, _z);
    }

    float ScaleControlVectorAxis (Vector3 _refVec, Vector3 _ctrlVec){
        //Return absolute value of Cosine of the angle between two vectors 
        return Mathf.Abs(Mathf.Cos(Vector3.Angle(_refVec,_ctrlVec)*(Mathf.PI/180f)));
    }

    void PrintInstuctions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }




}
