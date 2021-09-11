using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Debug.Log("Hit " + this.tag + "!");
            GetComponent<MeshRenderer>().material.color = Color.yellow;
            gameObject.tag = "hitObject";
        }
    }
}
