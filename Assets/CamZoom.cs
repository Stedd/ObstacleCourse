using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,Input.GetAxis("Mouse ScrollWheel"));
        
    }
}
