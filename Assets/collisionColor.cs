using UnityEngine;
using System.Collections;

public class collisionColor : MonoBehaviour {


    

    void OnCollisionEnter(Collision collision)
    {

        gameObject.GetComponent<Renderer>().material.color = Color.red;

    }

    void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<Renderer>().material.color=Color.clear;
    }
}
