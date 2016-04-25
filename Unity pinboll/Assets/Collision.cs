using UnityEngine;
using System.Collections;

public partial class Collision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ob_cube")
        {
            Behaviour b = (Behaviour)collision.gameObject.GetComponent("Halo");
            b.enabled = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (collision.gameObject.tag == "ob_cube")
        {
            Behaviour b = (Behaviour)collision.gameObject.GetComponent("Halo");
            b.enabled = false;
            Vector3 v = rigidbody.velocity;
            if (v.magnitude < 15)
            {
                v *= 2.0f;
                if (v.magnitude < 5)
                {
                    v *= 2.0f;
                }
                rigidbody.velocity = v;
            }
        }
        if (collision.gameObject.tag == "ob_wall")
        {
            Vector3 v = rigidbody.velocity;
            if (v.magnitude < 15)
            {
                v *= 2.0f;
                if (v.magnitude < 5)
                {
                    v *= 2.0f;
                }
                rigidbody.velocity = v;
            }
        }
    }
}
