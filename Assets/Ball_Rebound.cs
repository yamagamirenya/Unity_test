using UnityEngine;
using System.Collections;

public class Ball_Rebound : MonoBehaviour {

    // public GameObject ball;


    void OnCollisionEnter(Collision other) {
        var target = other.gameObject;
        
        Rigidbody rigidbody = target.GetComponent<Rigidbody>();
        rigidbody.AddForce(new Vector3(Random.Range(-2000,2000), 0, Random.Range(-2000, 2000)));
        
    }

}
